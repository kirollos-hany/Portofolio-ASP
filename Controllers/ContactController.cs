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
using Portofolio.AppModels.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly BaseRepository<Contact> contactRepository;
        private readonly BaseRepository<Service> serviceRepository;

        private readonly IMailService mailService;

        private readonly BaseRepository<RequestedService> requestedServicesRepository;

        private readonly IEmailParserFromModelAsync<HTMLWithModel<Contact>> contactEmailParser;

        private readonly UserManager<User> userManager;

        private readonly BaseRepository<ContactStatus> contactStatusRepository;
        public ContactController(BaseRepository<ContactStatus> contactStatusRepository, UserManager<User> userManager, BaseRepository<Contact> contactRepository, IEmailParserFromModelAsync<HTMLWithModel<Contact>> contactEmailParser, BaseRepository<Service> serviceRepository, BaseRepository<RequestedService> requestedServicesRepository, IMailService mailService)
        {
            this.mailService = mailService;
            this.contactRepository = contactRepository;
            this.serviceRepository = serviceRepository;
            this.requestedServicesRepository = requestedServicesRepository;
            this.contactEmailParser = contactEmailParser;
            this.userManager = userManager;
            this.contactStatusRepository = contactStatusRepository;
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
            var contact = await contactRepository.GetById(savedContact.Id);
            var mailRequest = await contactEmailParser.ParseAsync(new HTMLWithModel<Contact>
            {
                Model = contactData.Contact,
                Path = "templates/servicerequest.html",
                HrefValue = $"href={Url.ActionLink(nameof(ContactController.ContactDetails), "Contact", new {id = contactData.Contact.Id}, Request.Scheme)}"
            });
            await mailService.SendEmailAsync(mailRequest);
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Contact received successfuly, we will contact you asap!",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(controllerName: "Contact", actionName: "Index");
        }
        [Authorize]
        public async Task<IActionResult> ContactDetails(int id)
        {
            var contact = await contactRepository.GetById(id);
            var user = await userManager.GetUserAsync(HttpContext.User);
            var statuses = await contactStatusRepository.GetAll();
            return View(new ContactDetailsViewModel
            {
                Contact = contact,
                User = user,
                ContactStatuses = statuses
            });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditContactStatus(ContactDetailsViewModel editViewModel)
        {
            if (editViewModel.StatusId == default(int))
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = "Please select a new status for the contact",
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
            }
            else
            {
                var contact = await contactRepository.GetById(editViewModel.Contact.Id);
                contact.StatusId = editViewModel.StatusId;
                await contactRepository.Edit(contact);
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = "Contact editted successfuly",
                    CssClass = ResultMsgViewModel.CssClassSuccess
                });
            }
            return RedirectToAction(nameof(ContactDetails), new {id = editViewModel.Contact.Id});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}