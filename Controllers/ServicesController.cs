using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Portofolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly BaseRepository<Service> repository;

        public ServicesController(BaseRepository<Service> repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> services = await repository.GetAll();
            return View(services);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View("services/index", service);
            }
            await repository.Create(service);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}