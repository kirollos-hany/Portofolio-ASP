using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;
using Portofolio.AppModels.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Portofolio.ViewModels;
using Microsoft.EntityFrameworkCore;
using Portofolio.AppModels.Services;
using Portofolio.AppModels.Extensions;
using static Portofolio.AppModels.Utils.KeyConstants;
using Portofolio.AppModels.Exceptions;
using Json.Net;
using Microsoft.AspNetCore.Http;
using Portofolio.AppModels.Models;
namespace Portofolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly BaseRepository<Project> projectsRepository;

        private readonly UserManager<User> userManager;
        private readonly BaseRepository<UsersInProject> uipRepository;
        private readonly BaseRepository<ProjectType> projectTypeRepository;

        private readonly BaseRepository<LinkType> linkTypesRepository;

        private readonly BaseRepository<UserRoleInProject> uripRepository;

        private readonly BaseRepository<ProjectLink> projectLinksRepository;

        private readonly BaseRepository<ProjectImage> projectImagesRepository;

        private readonly BaseImageServices<Project> imageServices;

        private readonly BaseRepository<ProjectFeedback> feedbackRepository;

        public ProjectsController(BaseRepository<ProjectFeedback> feedbackRepository, BaseRepository<ProjectImage> projectImagesRepository, BaseRepository<ProjectLink> projectLinksRepository, BaseRepository<UsersInProject> uipRepository, BaseImageServices<Project> imageServices, BaseRepository<UserRoleInProject> uripRepository, BaseRepository<LinkType> linkTypesRepository, BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<ProjectType> projectTypeRepository)
        {
            this.userManager = userManager;
            this.projectsRepository = projectsRepository;
            this.projectTypeRepository = projectTypeRepository;
            this.linkTypesRepository = linkTypesRepository;
            this.uripRepository = uripRepository;
            this.imageServices = imageServices;
            this.uipRepository = uipRepository;
            this.projectLinksRepository = projectLinksRepository;
            this.projectImagesRepository = projectImagesRepository;
            this.feedbackRepository = feedbackRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await projectsRepository.GetAll());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await projectsRepository.GetById(id));
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var users = await userManager.Users.ToListAsync();
            var projectTypes = await projectTypeRepository.GetAll();
            var linkTypes = await linkTypesRepository.GetAll();
            var urips = await uripRepository.GetAll();
            return View(new CreateProjectViewModel
            {
                User = user,
                Users = users,
                ProjectTypes = projectTypes,
                LinkTypes = linkTypes,
                UserRolesInProject = urips
            });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProjectViewModel projectViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(Create));
            }
            var project = await projectsRepository.Create(new Project
            {
                Title = projectViewModel.Title,
                Description = projectViewModel.Description,
                TypeId = projectViewModel.ProjectTypeId,
                ToolsUsed = projectViewModel.ToolsUsed
            });
            await uipRepository.CreateFromCollection(project.Id, projectViewModel.UsersNRolesIds, '-');
            await projectLinksRepository.CreateFromCollection(project.Id, projectViewModel.LinkTypesIds, projectViewModel.ProjectLinks);
            try
            {
                imageServices.ValidateImgExtension(projectViewModel.ProjectThumbnail);
                project.Thumbnail = await imageServices.UploadImgAsync(projectViewModel.ProjectThumbnail);
                await projectsRepository.Edit(project);
            }
            catch (CustomException ex)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = ex.Message,
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
            }
            if (projectViewModel.ProjectImages != null)
            {
                try
                {
                    await projectImagesRepository.CreateFromCollection(project.Id, projectViewModel.ProjectImages, imageServices);
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
                Message = "Project created successfully",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProjectDetailsDashboardViewModel editViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(Create));
            }
            var edittedProject = await projectsRepository.Edit(new Project
            {
                Id = editViewModel.ProjectId,
                Title = editViewModel.Title,
                Description = editViewModel.Description,
                ToolsUsed = editViewModel.ToolsUsed,
                TypeId = editViewModel.ProjectTypeId
            });
            await uipRepository.EditFromCollection(edittedProject.UsersInProjects, editViewModel.UsersNRolesIds, '-');
            if (editViewModel.AddUsersNRolesIds != null && editViewModel.AddUsersNRolesIds.Count != 0)
            {
                await uipRepository.CreateFromCollection(editViewModel.ProjectId, editViewModel.AddUsersNRolesIds, '-');
            }
            await projectLinksRepository.EditFromCollection(editViewModel.LinksIds, editViewModel.ProjectLinks);
            if (editViewModel.ProjectThumbnail != null)
            {
                try
                {
                    imageServices.ValidateImgExtension(editViewModel.ProjectThumbnail);
                    string imagePath = await imageServices.UploadImgAsync(editViewModel.ProjectThumbnail);
                    imageServices.DeleteImg(edittedProject.Thumbnail);
                    edittedProject.Thumbnail = imagePath;
                    await projectsRepository.Edit(edittedProject);
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
            if (editViewModel.ProjectImages != null && editViewModel.ProjectImages.Count != 0)
            {
                try
                {
                    await projectImagesRepository.CreateFromCollection(edittedProject.Id, editViewModel.ProjectImages, imageServices);
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
                Message = "Project editted successfully",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(nameof(DashboardController.ProjectDetails), "Dashboard", new { id = editViewModel.ProjectId });
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var project = await projectsRepository.GetById(id);
            if (project.ProjectFeedbacks != null && project.ProjectFeedbacks.Count != 0)
            {
                await feedbackRepository.DeleteCollection(project.ProjectFeedbacks);
            }
            foreach (var image in project.ProjectImages)
            {
                imageServices.DeleteImg(image.ImagePath);
            }
            await projectImagesRepository.DeleteCollection(project.ProjectImages);
            await projectLinksRepository.DeleteCollection(project.ProjectLinks);
            await uipRepository.DeleteCollection(project.UsersInProjects);
            await projectsRepository.Delete(project);
            return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
        }

        [Authorize]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await projectImagesRepository.GetById(id);
            imageServices.DeleteImg(image.ImagePath);
            await projectImagesRepository.Delete(image);
            return RedirectToAction(nameof(DashboardController.ProjectDetails), "Dashboard", new { id = image.ProjectId });
        }

        public async Task<IActionResult> Image(int id, [FromQuery] bool isThumbnail)
        {
            ImageModel imageModel = new ImageModel();
            if (isThumbnail)
            {
                var project = await projectsRepository.GetById(id);
                imageModel = await imageServices.GetImageAsync(project.Thumbnail);
            }
            else
            {
                var project = await projectImagesRepository.GetById(id);
                imageModel = await imageServices.GetImageAsync(project.ImagePath);
            }
            return File(imageModel.FileStream, imageModel.ContentType);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}