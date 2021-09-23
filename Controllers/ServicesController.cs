using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Portofolio.ViewModels;
using Portofolio.AppModels.Extensions;
using static Portofolio.AppModels.Utils.Constants;
using Portofolio.AppModels.Services;
using Portofolio.AppModels.Exceptions;
using Microsoft.AspNetCore.Identity;
namespace Portofolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IRepository<Service> _repository;

        private readonly IImageServices _imageServices;

        private readonly IPaginator<Service> _paginator;

        private readonly UserManager<User> _userManager;

        private readonly IRepository<ServicesLog> _servicesLogRepository;

        private readonly IDisplayOutput _outputDisplayer;

        public ServicesController(IDisplayOutput outputDisplayer, UserManager<User> userManager, BaseRepository<ServicesLog> servicesLogRepository, BasePaginator<Service> paginator, BaseRepository<Service> repository, IImageServices imageServices)
        {
            _repository = repository;
            _imageServices = imageServices;
            _paginator = paginator;
            _userManager = userManager;
            _servicesLogRepository = servicesLogRepository;
            _outputDisplayer = outputDisplayer;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ICollection<Service> services = await _repository.GetAll();
            var paginatedModel = _paginator.Paginate(services, page);
            return View(paginatedModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ServicesDashboardVM serviceVM)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
            }
            var service = new Service
            {
                ServiceName = serviceVM.Name,
                ServiceDescription = serviceVM.Description
            };
            if (serviceVM.ServiceImage != null)
            {
                service.ServiceImage = await _imageServices.UploadImgAsync(serviceVM.ServiceImage);
            }
            await _repository.Create(service);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _servicesLogRepository.Create(new ServicesLog
            {
                ServiceId = service.Id,
                UserId = user.Id,
                ServiceName = service.ServiceName,
                Action = LogActions.Create.ToString(),
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var service = await _repository.GetById(id);
            _imageServices.DeleteImg(service.ServiceImage);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _servicesLogRepository.Create(new ServicesLog
            {
                ServiceId = service.Id,
                UserId = user.Id,
                ServiceName = service.ServiceName,
                Action = LogActions.Delete.ToString(),
                UserName = user.UserName
            });
            await _repository.Delete(service);
            return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ServicesDashboardVM model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignViewDataWithErrors(ViewData);
                return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
            }
            if (model.ServiceImage != null)
            {
                try
                {
                    var service = new Service
                    {
                        Id = id,
                        ServiceName = model.Name,
                        ServiceDescription = model.Description
                    };
                    _imageServices.ValidateImgExtension(model.ServiceImage);
                    _imageServices.DeleteImg(service.ServiceImage);
                    service.ServiceImage = await _imageServices.UploadImgAsync(model.ServiceImage);
                    await _repository.Edit(service);
                }
                catch (CustomException ex)
                {
                    _outputDisplayer.DisplayOutput(ViewData, false, ex.Message);
                    return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
                }
            }else
            {
                var service = await _repository.GetById(id);
                var newService = new Service{
                    Id = id,
                    ServiceName = model.Name,
                    ServiceDescription = model.Description,
                    ServiceImage = service.ServiceImage
                };
                await _repository.Edit(newService);
            }
            _outputDisplayer.DisplayOutput(ViewData, true, "Service edit successful");
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _servicesLogRepository.Create(new ServicesLog
            {
                ServiceId = id,
                UserId = user.Id,
                ServiceName = model.Name,
                Action = LogActions.Update.ToString(),
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}