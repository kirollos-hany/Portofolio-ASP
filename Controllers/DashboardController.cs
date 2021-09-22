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

        private readonly IImageServices _imageServices;

        private readonly IRepository<Service> _servicesRepository;

        private readonly IPaginator<Project> _projectsPaginator;

        private readonly IPaginator<Service> _servicePaginator;

        private readonly IRepository<ProjectLog> _projectsLogsRepo;

        private readonly IRepository<ContactLog> _contactsLogsRepo;

        private readonly IRepository<ServicesLog> _servicesLogsRepo;

        private readonly IPaginator<User> _usersPaginator;

        public DashboardController(RoleManager<UserRole> roleManager, BasePaginator<User> usersPaginator, BaseRepository<ServicesLog> servicesLogsRepo, BaseRepository<ContactLog> contactsLogsRepo, BaseRepository<ProjectLog> projectsLogsRepo, BasePaginator<Service> servicePaginator, BasePaginator<Project> projectsPaginator, BaseRepository<Service> servicesRepository, IImageServices imageServices, BaseRepository<ProjectImage> projectImagesRepository, BaseRepository<ProjectLink> projectLinksRepository, BaseRepository<UserRoleInProject> uripRepository, BaseRepository<LinkType> linkTypesRepository, BaseRepository<ProjectType> projectTypeRepository, BaseRepository<Contact> contactsRepository, BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository)
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
            _projectsLogsRepo = projectsLogsRepo;
            _servicesLogsRepo = servicesLogsRepo;
            _contactsLogsRepo = contactsLogsRepo;
            _usersPaginator = usersPaginator;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact) => contact.Status.Status == "Pending")).Count;
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
            var project = await _projectsRepository.GetById(id);
            if (project == null)
            {
                return RedirectToAction(nameof(ErrorsController.Error404), "Error");
            }
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact) => contact.Status.Status == "Pending")).Count;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var users = await _userManager.Users.ToListAsync();
            foreach (var userInProject in project.UsersInProjects)
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
            contacts = contacts.OrderByDescending((contact) => contact.UpdatedAt).ToHashSet();
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
            var pendingContactsCount = (await _contactsRepository.FindCollectionByCondition((contact) => contact.Status.Status == "Pending")).Count;
            var services = await _servicesRepository.GetAll();
            var paginationModel = _servicePaginator.Paginate(services, page);
            return View(new ServicesDashboardVM
            {
                User = await _userManager.GetUserAsync(HttpContext.User),
                PendingContactsCount = pendingContactsCount,
                PaginationModel = paginationModel
            });
        }

        public async Task<IActionResult> ProjectsLogs()
        {
            var logs = await _projectsLogsRepo.GetAll();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == "Pending").Count();
            return View(new ProjectsLogsVM
            {
                Logs = logs,
                PendingContactsCount = pendingContactsCount,
                User = user
            });
        }

        public async Task<IActionResult> ContactsLogs()
        {
            var logs = await _contactsLogsRepo.GetAll();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == "Pending").Count();
            return View(new ContactsLogsVM
            {
                Logs = logs,
                PendingContactsCount = pendingContactsCount,
                User = user
            });
        }

        public async Task<IActionResult> ServicesLogs()
        {
            var logs = await _servicesLogsRepo.GetAll();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == "Pending").Count();
            return View(new ServicesLogsVM
            {
                Logs = logs,
                PendingContactsCount = pendingContactsCount,
                User = user
            });

        }
        public async Task<IActionResult> Members(int page = 1)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = await _userManager.Users.OrderByDescending((user) => user.CreatedAt).ToListAsync();
            users.Remove(user);
            var paginationModel = _usersPaginator.Paginate(users, page);
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == "Pending").Count();
            return View(new MembersDashboardVM
            {
                User = user,
                PendingContactsCount = pendingContactsCount,
                UsersPagination = paginationModel
            });
        }


        public async Task<IActionResult> DeleteMember(int id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                var users = await _userManager.Users.ToListAsync();
                var userToDelete = users.Where((user) => user.Id == id).FirstOrDefault();
                if (user != default(User))
                {
                    await _userManager.DeleteAsync(userToDelete);
                }
                return RedirectToAction(nameof(Members));
            }else
            {
                return StatusCode(401);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}