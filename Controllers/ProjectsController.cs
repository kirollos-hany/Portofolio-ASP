using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;
using Portofolio.AppModels.Repositories;
using System.Threading.Tasks;
namespace Portofolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly BaseRepository<Project> repository;

        public ProjectsController(BaseRepository<Project> repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await repository.GetAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}