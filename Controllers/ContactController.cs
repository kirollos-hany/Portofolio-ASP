using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Diagnostics;
namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly BaseRepository<Contact> repository;
        public ContactController(BaseRepository<Contact> repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitContact(Contact contactData)
        {
            if (!ModelState.IsValid)
            {
                return View("contact/index", contactData);
            }
            await repository.Create(contactData);
            return RedirectToAction(controllerName: "Contact", actionName: "Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}