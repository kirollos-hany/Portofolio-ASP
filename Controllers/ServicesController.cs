using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Portofolio.Models;
using Portofolio.AppModels.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Portofolio.ViewModels;
using Portofolio.AppModels.Extensions;
using static Portofolio.AppModels.Utils.KeyConstants;
using Json.Net;
using Portofolio.AppModels.Services;
using Portofolio.AppModels.Exceptions;
namespace Portofolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IRepository<Service> _repository;

        private readonly IImageService _imageServices;

        private readonly IPaginator<Service> _paginator;

        public ServicesController(BasePaginator<Service> paginator, BaseRepository<Service> repository, BaseImageServices<Service> imageServices)
        {
            _repository = repository;
            _imageServices = imageServices;
            _paginator = paginator;
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
            return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
        }

        public async Task<IActionResult> Image(int id)
        {
            var service = await _repository.GetById(id);
            var imageModel = await _imageServices.GetImageAsync(service.ServiceImage);
            return File(imageModel.FileStream, imageModel.ContentType);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var service = await _repository.GetById(id);
            _imageServices.DeleteImg(service.ServiceImage);
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
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
            }
            var service = new Service
            {
                Id = id,
                ServiceName = model.Name,
                ServiceDescription = model.Description
            };
            service = await _repository.Edit(service);
            if (model.ServiceImage != null)
            {
                try
                {
                    _imageServices.ValidateImgExtension(model.ServiceImage);
                    _imageServices.DeleteImg(service.ServiceImage);
                    service.ServiceImage = await _imageServices.UploadImgAsync(model.ServiceImage);
                    await _repository.Edit(service);
                }
                catch (CustomException ex)
                {
                    TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                    {
                        Message = ex.Message,
                        CssClass = ResultMsgViewModel.CssClassFailed
                    });
                }
            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Service edit successful",
                CssClass = ResultMsgViewModel.CssClassSuccess
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