using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Portofolio.AppModels.Repositories;
using Portofolio.AppModels.Services;
using Portofolio.ViewModels;
using System;
namespace Portofolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly IRepository<UsersInProject> _uipRepository;

        private readonly IRepository<UserLink> _userLinksRepository;

        private readonly IPaginator<User> _usersPaginator;

        public HomeController(BasePaginator<User> usersPaginator, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository, BaseRepository<UserLink> userLinksRepository)
        {
            _userManager = userManager;
            _uipRepository = uipRepository;
            _userLinksRepository = userLinksRepository;
            _usersPaginator = usersPaginator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Members(int page = 1)
        {
            var users = await Task.Run(() => _userManager.Users.ToHashSet());
            users = users.OrderByDescending((user) => user.CreatedAt).ToHashSet();
            var paginationVM = _usersPaginator.Paginate(users, page);
            foreach(var user in paginationVM.Collection)
            {
                user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip)=>uip.UserId == user.Id);
                user.UserLinks = await _userLinksRepository.FindCollectionByCondition((link)=>link.UserId == user.Id);
            }
            return View(paginationVM);
        }

        public async Task<IActionResult> Profile(int id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync((user) => user.Id == id);
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            user.UserLinks = await _userLinksRepository.FindCollectionByCondition((link) => link.UserId == user.Id);
            return View(user);
        }

        public IActionResult Blog()
        {
            return View();
        }


        public IActionResult BlogSingle()
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
