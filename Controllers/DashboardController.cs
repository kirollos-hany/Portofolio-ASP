using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;

namespace Portofolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}