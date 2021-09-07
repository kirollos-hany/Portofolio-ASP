using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Portofolio.AppModels.Repositories;
using Microsoft.AspNetCore.Identity;
using Portofolio.ViewModels;
using Portofolio.AppModels.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Portofolio.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IRepository<Project> _projectsRepository;
        private readonly UserManager<User> _userManager;

        private readonly IRepository<UsersInProject> _uipRepository;

        private readonly IRepository<Contact> _contactsRepository;

        private readonly IRepository<ProjectType> _projectTypeRepository;

        private readonly IRepository<LinkType> _linkTypesRepository;

        private readonly IRepository<UserRoleInProject> _uripRepository;
        private readonly IRepository<ProjectLink> _projectLinksRepository;

        private readonly IRepository<ProjectImage> _projectImagesRepository;

        private readonly IImageService _imageServices;

        private readonly IRepository<Service> _servicesRepository;

        private readonly IPaginator<Project> _projectsPaginator;

        private readonly IPaginator<Service> _servicePaginator;
        public DashboardController(BasePaginator<Service> servicePaginator, BasePaginator<Project> projectsPaginator, BaseRepository<Service> servicesRepository, BaseImageServices<Project> imageServices, BaseRepository<ProjectImage> projectImagesRepository, BaseRepository<ProjectLink> projectLinksRepository, BaseRepository<UserRoleInProject> uripRepository, BaseRepository<LinkType> linkTypesRepository, BaseRepository<ProjectType> projectTypeRepository, BaseRepository<Contact> contactsRepository, BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository)
        {
            _projectsRepository = projectsRepository;
            _userManager = userManager;
            _uipRepository = uipRepository;
            _contactsRepository = contactsRepository;
            _projectTypeRepository = projectTypeRepository;
            _linkTypesRepository = linkTypesRepository;
            _uripRepository = uripRepository;
            _projectLinksRepository = projectLinksRepository;
            _projectImagesRepository = projectImagesRepository;
            _imageServices = imageServices;
            _servicesRepository = servicesRepository;
            _projectsPaginator = projectsPaginator;
            _servicePaginator = servicePaginator;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact)=>contact.Status.Status == "Pending")).Count;
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var projects = await _projectsRepository.GetAll();
            var paginationModel = _projectsPaginator.Paginate(projects, page);
            return View(new ProjectsDashboardViewModel
            {
                User = user,
                PendingContactsCount = pendingContactsCount,
                PaginationModel = paginationModel
            });
        }

        public async Task<IActionResult> ProjectDetails(int id)
        {
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact)=>contact.Status.Status == "Pending")).Count;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var project = await _projectsRepository.GetById(id);
            var users = await _userManager.Users.ToListAsync();
            foreach(var userInProject in project.UsersInProjects)
            {
                users.Remove(userInProject.User);
            }
            var projectTypes = await _projectTypeRepository.GetAll();
            var linkTypes = await _linkTypesRepository.GetAll();
            var urips = await _uripRepository.GetAll();
            return View(new ProjectDetailsDashboardViewModel
            {
                User = user,
                PendingContactsCount = pendingContactsCount,
                Users = users,
                ChosenProject = project,
                ProjectTypes = projectTypes,
                UserRolesInProject = urips,
            });
        }

        public async Task<IActionResult> Contacts()
        {
            var contacts = await _contactsRepository.GetAll();
            contacts = contacts.OrderByDescending((contact)=>contact.UpdatedAt).ToHashSet();
            var pendingContactsCount = (contacts.Where((contact) => contact.Status.Status == "Pending").ToHashSet()).Count;
            return View(new ContactsDashboardViewModel
            {
                User = await _userManager.GetUserAsync(HttpContext.User),
                PendingContactsCount = pendingContactsCount,
                Contacts = contacts
            });
        }

        public async Task<IActionResult> Services(int page = 1)
        {
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact)=>contact.Status.Status == "Pending")).Count;
            var services = await _servicesRepository.GetAll();
            var paginationModel = _servicePaginator.Paginate(services, page);
            return View(new ServicesDashboardVM{
                User = await _userManager.GetUserAsync(HttpContext.User),
                PendingContactsCount = pendingContactsCount,
                PaginationModel = paginationModel
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}