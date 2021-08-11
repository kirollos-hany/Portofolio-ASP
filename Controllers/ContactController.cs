using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Diagnostics;
using Portofolio.ViewModels;
namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly BaseRepository<Contact> contactRepository;
        private readonly BaseRepository<Service> serviceRepository;

        private readonly BaseRepository<RequestedService> requestedServicesRepository;
        public ContactController(BaseRepository<Contact> contactRepository, BaseRepository<Service> serviceRepository, BaseRepository<RequestedService> requestedServicesRepository)
        {
            this.contactRepository = contactRepository;
            this.serviceRepository = serviceRepository;
            this.requestedServicesRepository = requestedServicesRepository;
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
        public async Task<IActionResult> SubmitContact(ContactWithServicesViewModel contactData)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(controllerName: "Contact", actionName: "Index");
            }
            Contact savedContact = await contactRepository.Create(contactData.Contact);
            await requestedServicesRepository.CreateFromIds(contactData.RequestedServicesIds, savedContact.Id);
            return RedirectToAction(controllerName: "Contact", actionName: "Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}