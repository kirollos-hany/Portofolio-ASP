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
        private readonly BaseRepository<Service> repository;

        private readonly BaseImageServices<Service> imageServices;

        public ServicesController(BaseRepository<Service> repository, BaseImageServices<Service> imageServices)
        {
            this.repository = repository;
            this.imageServices = imageServices;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Service> services = await repository.GetAll();
            return View(services);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ServicesDashboardVM serviceVM)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
            }
            var service = new Service{
                ServiceName = serviceVM.Name,
                ServiceDescription = serviceVM.Description
            };
            if(serviceVM.ServiceImage != null)
            {
                service.ServiceImage = await imageServices.UploadImgAsync(serviceVM.ServiceImage);
            }
            await repository.Create(service);
            return RedirectToAction(nameof(DashboardController.Services), "Dashboard");
        }

        public async Task<IActionResult> Image(int id)
        {
            var service = await repository.GetById(id);
            var imageModel = await imageServices.GetImageAsync(service.ServiceImage);
            return File(imageModel.FileStream, imageModel.ContentType);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var service = await repository.GetById(id);
            imageServices.DeleteImg(service.ServiceImage);
            await repository.Delete(service);
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
            service = await repository.Edit(service);
            if (model.ServiceImage != null)
            {
                try
                {
                    imageServices.ValidateImgExtension(model.ServiceImage);
                    imageServices.DeleteImg(service.ServiceImage);
                    service.ServiceImage = await imageServices.UploadImgAsync(model.ServiceImage);
                    await repository.Edit(service);
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