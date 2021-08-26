using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Diagnostics;
using Portofolio.ViewModels;
using Portofolio.AppModels.Services;
using Json.Net;
using static Portofolio.AppModels.Utils.KeyConstants;
using Portofolio.AppModels.Extensions;
namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly BaseRepository<Contact> contactRepository;
        private readonly BaseRepository<Service> serviceRepository;

        private readonly IMailService mailService;

        private readonly BaseRepository<RequestedService> requestedServicesRepository;

        private readonly IEmailParserFromModel<Contact> contactEmailParser;
        public ContactController(BaseRepository<Contact> contactRepository, IEmailParserFromModel<Contact> contactEmailParser, BaseRepository<Service> serviceRepository, BaseRepository<RequestedService> requestedServicesRepository, IMailService mailService)
        {
            this.mailService = mailService;
            this.contactRepository = contactRepository;
            this.serviceRepository = serviceRepository;
            this.requestedServicesRepository = requestedServicesRepository;
            this.contactEmailParser = contactEmailParser;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new ContactWithServicesViewModel
            {
                Services = await serviceRepository.GetAll(),
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitContact(ContactWithServicesViewModel contactData)
        {
            if (!ModelState.IsValid)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = ModelState.GetErrors(),
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
                return RedirectToAction(controllerName: "Contact", actionName: "Index");
            }
            Contact savedContact = await contactRepository.Create(contactData.Contact);
            await requestedServicesRepository.CreateFromIds(contactData.RequestedServicesIds, savedContact.Id);
            var mailRequest = contactEmailParser.Parse(await contactRepository.GetById(savedContact.Id));
            await mailService.SendEmailAsync(mailRequest);
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Contact received successfuly, we will contact you asap!",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(controllerName: "Contact", actionName: "Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}