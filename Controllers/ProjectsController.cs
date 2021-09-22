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
using System.Collections.Generic;
using System;
using System.Linq;
using static Portofolio.AppModels.Utils.Constants;
namespace Portofolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IRepository<Project> _projectsRepository;

        private readonly UserManager<User> _userManager;
        private readonly IRepository<UsersInProject> _uipRepository;
        private readonly IRepository<ProjectType> _projectTypeRepository;

        private readonly IRepository<LinkType> _linkTypesRepository;

        private readonly IRepository<UserRoleInProject> _uripRepository;

        private readonly IRepository<ProjectLink> _projectLinksRepository;

        private readonly IRepository<ProjectImage> _projectImagesRepository;

        private readonly IImageServices _imageServices;

        private readonly IRepository<ProjectFeedback> _feedbackRepository;

        private readonly IPaginator<Project> _projectPaginator;

        private readonly IRepository<ProjectLog> _projectLogRepository;

        private readonly IRepository<Contact> _contactsRepository;

        public ProjectsController(BaseRepository<Contact> contactsRepository, BaseRepository<ProjectLog> projectLogRepository, BasePaginator<Project> projectPaginator, BaseRepository<ProjectFeedback> feedbackRepository, BaseRepository<ProjectImage> projectImagesRepository, BaseRepository<ProjectLink> projectLinksRepository, BaseRepository<UsersInProject> uipRepository, IImageServices imageServices, BaseRepository<UserRoleInProject> uripRepository, BaseRepository<LinkType> linkTypesRepository, BaseRepository<Project> projectsRepository, UserManager<User> userManager, BaseRepository<ProjectType> projectTypeRepository)
        {
            _userManager = userManager;
            _projectsRepository = projectsRepository;
            _projectTypeRepository = projectTypeRepository;
            _linkTypesRepository = linkTypesRepository;
            _uripRepository = uripRepository;
            _imageServices = imageServices;
            _uipRepository = uipRepository;
            _projectLinksRepository = projectLinksRepository;
            _projectImagesRepository = projectImagesRepository;
            _feedbackRepository = feedbackRepository;
            _projectPaginator = projectPaginator;
            _projectLogRepository = projectLogRepository;
            _contactsRepository = contactsRepository;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var projects = await _projectsRepository.GetAll();
            var paginationVM = _projectPaginator.Paginate(projects, page);
            return View(paginationVM);
        }

        public async Task<IActionResult> Details(int id)
        {
            var project = await _projectsRepository.GetById(id);
            if(project == null)
            {
                return RedirectToAction(nameof(ErrorsController.Error404), "Error");
            }
            return View(new ProjectDetailsViewModel
            {
                Project = await _projectsRepository.GetById(id)
            });
        }

        public async Task<IActionResult> Feedback(ProjectDetailsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(Details), new { id = model.ProjectId });
            }
            await _feedbackRepository.Create(new ProjectFeedback
            {
                ProjectId = model.ProjectId,
                Feedback = model.Feedback
            });
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Feedback submitted successfully",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(nameof(Details), new { id = model.ProjectId });
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = await _userManager.Users.ToListAsync();
            var projectTypes = await _projectTypeRepository.GetAll();
            var linkTypes = await _linkTypesRepository.GetAll();
            var urips = await _uripRepository.GetAll();
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == "Pending").Count();
            return View(new CreateProjectViewModel
            {
                PendingContactsCount = pendingContactsCount,
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
            var teamLeaderRole = await _uripRepository.FindByCondition((urip) => urip.Role == "Team Leader");
            var teamLeader = projectViewModel.UsersNRolesIds.Where((usersNRoleId) => Convert.ToInt32(usersNRoleId.Split('-')[0]) == teamLeaderRole.Id).FirstOrDefault();
            if(teamLeader == default(string))
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = "Please select a team leader for the project",
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
                return RedirectToAction(nameof(Create));
            }
            var project = await _projectsRepository.Create(new Project
            {
                Title = projectViewModel.Title,
                Description = projectViewModel.Description,
                TypeId = projectViewModel.ProjectTypeId,
                ToolsUsed = projectViewModel.ToolsUsed
            });
            await _uipRepository.CreateFromCollection(project.Id, projectViewModel.UsersNRolesIds, '-');
            await _projectLinksRepository.CreateFromCollection(project.Id, projectViewModel.LinkTypesIds, projectViewModel.ProjectLinks);
            try
            {
                _imageServices.ValidateImgExtension(projectViewModel.ProjectThumbnail);
                project.Thumbnail = await _imageServices.UploadImgAsync(projectViewModel.ProjectThumbnail);
                await _imageServices.ResizeImg(project.Thumbnail, ProjectImageSize);
                await _projectsRepository.Edit(project);
            }
            catch (CustomException ex)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = ex.Message,
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
                return RedirectToAction(nameof(Create));
            }
            if (projectViewModel.ProjectImages != null)
            {
                try
                {
                    await _projectImagesRepository.CreateFromCollection(project.Id, projectViewModel.ProjectImages, _imageServices);
                }
                catch (CustomException ex)
                {
                    TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                    {
                        Message = ex.Message,
                        CssClass = ResultMsgViewModel.CssClassFailed
                    });
                    return RedirectToAction(nameof(Create));
                }

            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Project created successfully",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _projectLogRepository.Create(new ProjectLog{
                ProjectId = project.Id,
                UserId = user.Id,
                Title = project.Title,
                Action = ProjectCreateAction,
                UserName = user.UserName
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
                return RedirectToAction(nameof(DashboardController.ProjectDetails), new {id = editViewModel.ProjectId});
            }
            var edittedProject = await _projectsRepository.Edit(new Project
            {
                Id = editViewModel.ProjectId,
                Title = editViewModel.Title,
                Description = editViewModel.Description,
                ToolsUsed = editViewModel.ToolsUsed,
                TypeId = editViewModel.ProjectTypeId
            });
            await _uipRepository.EditFromCollection(edittedProject.UsersInProjects, editViewModel.UsersNRolesIds, '-');
            if (editViewModel.AddUsersNRolesIds != null && editViewModel.AddUsersNRolesIds.Count != 0)
            {
                await _uipRepository.CreateFromCollection(editViewModel.ProjectId, editViewModel.AddUsersNRolesIds, '-');
            }
            await _projectLinksRepository.EditFromCollection(editViewModel.LinksIds, editViewModel.ProjectLinks);
            if (editViewModel.ProjectThumbnail != null)
            {
                try
                {
                    _imageServices.ValidateImgExtension(editViewModel.ProjectThumbnail);
                    string imagePath = await _imageServices.UploadImgAsync(editViewModel.ProjectThumbnail);
                    await _imageServices.ResizeImg(imagePath, ProjectImageSize);
                    _imageServices.DeleteImg(edittedProject.Thumbnail);
                    edittedProject.Thumbnail = imagePath;
                    await _projectsRepository.Edit(edittedProject);
                }
                catch (CustomException ex)
                {
                    TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                    {
                        Message = ex.Message,
                        CssClass = ResultMsgViewModel.CssClassFailed
                    });
                    return RedirectToAction(nameof(DashboardController.ProjectDetails), new {id = editViewModel.ProjectId});
                }
            }
            if (editViewModel.ProjectImages != null && editViewModel.ProjectImages.Count != 0)
            {
                try
                {
                    await _projectImagesRepository.CreateFromCollection(edittedProject.Id, editViewModel.ProjectImages, _imageServices);
                }
                catch (CustomException ex)
                {
                    TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                    {
                        Message = ex.Message,
                        CssClass = ResultMsgViewModel.CssClassFailed
                    });
                    return RedirectToAction(nameof(DashboardController.ProjectDetails), new {id = editViewModel.ProjectId});
                }
            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Project editted successfully",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _projectLogRepository.Create(new ProjectLog{
                ProjectId = edittedProject.Id,
                UserId = user.Id,
                Title = edittedProject.Title,
                Action = ProjectUpdateAction,
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.ProjectDetails), "Dashboard", new { id = editViewModel.ProjectId });
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var project = await _projectsRepository.GetById(id);
            if (project.ProjectFeedbacks != null && project.ProjectFeedbacks.Count != 0)
            {
                await _feedbackRepository.DeleteCollection(project.ProjectFeedbacks);
            }
            foreach (var image in project.ProjectImages)
            {
                _imageServices.DeleteImg(image.ImagePath);
            }
            await _projectImagesRepository.DeleteCollection(project.ProjectImages);
            await _projectLinksRepository.DeleteCollection(project.ProjectLinks);
            await _uipRepository.DeleteCollection(project.UsersInProjects);
            await _projectsRepository.Delete(project);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _projectLogRepository.Create(new ProjectLog{
                ProjectId = id,
                UserId = user.Id,
                Title = project.Title,
                Action = ProjectDeleteAction,
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
        }

        [Authorize]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await _projectImagesRepository.GetById(id);
            _imageServices.DeleteImg(image.ImagePath);
            await _projectImagesRepository.Delete(image);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var project = await _projectsRepository.GetById(image.ProjectId);
            await _projectLogRepository.Create(new ProjectLog{
                ProjectId = project.Id,
                UserId = user.Id,
                Title = project.Title,
                Action = ProjectImageDeleteAction,
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.ProjectDetails), "Dashboard", new { id = image.ProjectId });
        }

        [Authorize]
        public async Task<IActionResult> DeleteUip(int id)
        {
            var uip = await _uipRepository.GetById(id);
            await _uipRepository.Delete(uip);
            var project = await _projectsRepository.GetById(uip.ProjectId);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _projectLogRepository.Create(new ProjectLog{
                ProjectId = project.Id,
                UserId = user.Id,
                Title = project.Title,
                Action = ProjectUipDeleteAction,
                UserName = user.UserName
            });
            return RedirectToAction(nameof(DashboardController.ProjectDetails), "Dashboard", new {id = uip.ProjectId});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}