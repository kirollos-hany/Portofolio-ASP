using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Portofolio.AppModels.Repositories;
using Microsoft.AspNetCore.Identity;
using Portofolio.ViewModels;
namespace Portofolio.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly BaseRepository<Project> projectsRepository;
        private readonly UserManager<User> userManager;

        private readonly BaseRepository<UsersInProject> uipRepository;
        public DashboardController(BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository)
        {
            this.projectsRepository = projectsRepository;
            this.userManager = userManager;
            this.uipRepository = uipRepository;
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

        public async Task<IActionResult> ProjectDetails(int id){
            var user = await userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            var project = await projectsRepository.GetById(id);
            return View(new ProjectDetailsDashboardViewModel{
                User = user,
                ChosenProject = project
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}