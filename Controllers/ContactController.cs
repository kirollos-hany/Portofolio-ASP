using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Diagnostics;
using Portofolio.ViewModels;
using Portofolio.AppModels.Services;
using static Portofolio.AppModels.Utils.Constants;
using Portofolio.AppModels.Extensions;
using Portofolio.AppModels.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Linq;
namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IRepository<Contact> _contactRepository;
        private readonly IRepository<Service> _serviceRepository;

        private readonly IMailService _mailService;

        private readonly IRepository<RequestedService> _requestedServicesRepository;

        private readonly IEmailParserFromModelAsync<HTMLWithModel<Contact>> _contactEmailParser;

        private readonly UserManager<User> _userManager;

        private readonly SignInManager<User> _signInManager;

        private readonly IRepository<ContactStatus> _contactStatusRepository;

        private readonly IRepository<ContactLog> _contactLogsRepository;

        private readonly IDisplayOutput _outputDisplayer;

        public ContactController(IDisplayOutput outputDisplayer, SignInManager<User> signInManager, BaseRepository<ContactLog> contactLogsRepository, BaseRepository<ContactStatus> contactStatusRepository, UserManager<User> userManager, BaseRepository<Contact> contactRepository, IEmailParserFromModelAsync<HTMLWithModel<Contact>> contactEmailParser, BaseRepository<Service> serviceRepository, BaseRepository<RequestedService> requestedServicesRepository, IMailService mailService)
        {
            _mailService = mailService;
            _contactRepository = contactRepository;
            _serviceRepository = serviceRepository;
            _requestedServicesRepository = requestedServicesRepository;
            _contactEmailParser = contactEmailParser;
            _userManager = userManager;
            _contactStatusRepository = contactStatusRepository;
            _contactLogsRepository = contactLogsRepository;
            _signInManager = signInManager;
            _outputDisplayer = outputDisplayer;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new ContactWithServicesViewModel
            {
                Services = await _serviceRepository.GetAll(),
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactWithServicesViewModel contactData)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignViewDataWithErrors(ViewData);
                return RedirectToAction(controllerName: "Contact", actionName: "Index");
            }
            ContactStatus cs = await _contactStatusRepository.FindByCondition(cs => cs.Status == ContactStatuses.Pending.ToString());
            contactData.Contact.StatusId = cs.Id;
            Contact savedContact = await _contactRepository.Create(contactData.Contact);
            await _requestedServicesRepository.CreateFromIds(contactData.RequestedServicesIds, savedContact.Id);
            var contact = await _contactRepository.GetById(savedContact.Id);
            var mailRequest = await _contactEmailParser.ParseAsync(new HTMLWithModel<Contact>
            {
                Model = contactData.Contact,
                Path = ContactHtmlTemplatePath,
                HrefValue = $"href={Url.ActionLink(nameof(ContactController.ContactDetails), "Contact", new { id = contactData.Contact.Id }, Request.Scheme)}"
            });
            await _mailService.SendEmailAsync(mailRequest);
            _outputDisplayer.DisplayOutput(ViewData, true, "Contact received successfuly, we will contact you asap!");
            return RedirectToAction(controllerName: "Contact", actionName: "Index");
        }
        [Authorize]
        public async Task<IActionResult> ContactDetails(int id)
        {
            var contact = await _contactRepository.GetById(id);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var statuses = await _contactStatusRepository.GetAll();
            var pendingContactsCount = (await _contactRepository.GetAll()).Where((contact) => contact.Status.Status == ContactStatuses.Pending.ToString()).Count();
            return View(new ContactDetailsViewModel
            {
                PendingContactsCount = pendingContactsCount,
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
                _outputDisplayer.DisplayOutput(ViewData, false, "Please select a new status for the contact");
            }
            else
            {
                var contact = await _contactRepository.GetById(editViewModel.Contact.Id);
                contact.StatusId = editViewModel.StatusId;
                await _contactRepository.Edit(contact);
                _outputDisplayer.DisplayOutput(ViewData, true, "Contact editted successfuly");
                var user = await _userManager.GetUserAsync(HttpContext.User);
                await _contactLogsRepository.Create(new ContactLog
                {
                    ContactName = contact.ContactName,
                    Action = LogActions.Update.ToString(),
                    UserId = user.Id,
                    ContactId = contact.Id,
                    UserName = user.UserName
                });
            }
            return RedirectToAction(nameof(ContactDetails), new { id = editViewModel.Contact.Id });
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var contact = await _contactRepository.GetById(id);
            await _contactRepository.Delete(contact);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _contactLogsRepository.Create(new ContactLog
            {
                ContactName = contact.ContactName,
                Action = LogActions.Delete.ToString(),
                UserId = user.Id,
                ContactId = contact.Id,
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.Contacts), "Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}