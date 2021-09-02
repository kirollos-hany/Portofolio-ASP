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
namespace Portofolio.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly BaseRepository<Project> projectsRepository;
        private readonly UserManager<User> userManager;

        private readonly BaseRepository<UsersInProject> uipRepository;

        private readonly BaseRepository<Contact> contactsRepository;

        private readonly BaseRepository<ProjectType> projectTypeRepository;

        private readonly BaseRepository<LinkType> linkTypesRepository;

        private readonly BaseRepository<UserRoleInProject> uripRepository;

        private readonly BaseRepository<ImageType> imageTypeRepository;

        private readonly BaseRepository<ProjectLink> projectLinksRepository;

        private readonly BaseRepository<ProjectImage> projectImagesRepository;

        private readonly BaseImageServices<Project> imageServices;
        public DashboardController(BaseImageServices<Project> imageServices, BaseRepository<ProjectImage> projectImagesRepository, BaseRepository<ProjectLink> projectLinksRepository, BaseRepository<ImageType> imageTypeRepository, BaseRepository<UserRoleInProject> uripRepository, BaseRepository<LinkType> linkTypesRepository, BaseRepository<ProjectType> projectTypeRepository, BaseRepository<Contact> contactsRepository, BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository)
        {
            this.projectsRepository = projectsRepository;
            this.userManager = userManager;
            this.uipRepository = uipRepository;
            this.contactsRepository = contactsRepository;
            this.projectTypeRepository = projectTypeRepository;
            this.linkTypesRepository = linkTypesRepository;
            this.uripRepository = uripRepository;
            this.imageTypeRepository = imageTypeRepository;
            this.projectLinksRepository = projectLinksRepository;
            this.projectImagesRepository = projectImagesRepository;
            this.imageServices = imageServices;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var projects = await projectsRepository.GetAll();
            return View(new ProjectsDashboardViewModel
            {
                User = user,
                Projects = projects
            });
        }

        public async Task<IActionResult> ProjectDetails(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var project = await projectsRepository.GetById(id);
            var users = await userManager.Users.ToListAsync();
            foreach(var userInProject in project.UsersInProjects)
            {
                users.Remove(userInProject.User);
            }
            var projectTypes = await projectTypeRepository.GetAll();
            var linkTypes = await linkTypesRepository.GetAll();
            var urips = await uripRepository.GetAll();
            var thumbnailId = (await imageTypeRepository.FindByCondition((it => it.ImgType == "Thumbnail"))).Id;
            var otherId = (await imageTypeRepository.FindByCondition((it => it.ImgType == "Other"))).Id;
            return View(new ProjectDetailsDashboardViewModel
            {
                User = user,
                Users = users,
                ChosenProject = project,
                ProjectTypes = projectTypes,
                UserRolesInProject = urips,
                ThumbnailTypeId = thumbnailId,
                OtherTypeId = otherId
            });
        }

        public async Task<IActionResult> Contacts()
        {
            return View(new ContactsDashboardViewModel
            {
                User = await userManager.GetUserAsync(HttpContext.User),
                Contacts = await contactsRepository.GetAll()
            });
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}