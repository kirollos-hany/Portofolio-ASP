using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Models;
using System.Diagnostics;
using Portofolio.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Portofolio.AppModels.Extensions;
using Microsoft.AspNetCore.Authorization;
using Portofolio.AppModels.Repositories;
using Portofolio.AppModels.Services;
using Portofolio.AppModels.Exceptions;
using static Portofolio.AppModels.Utils.KeyConstants;
using Json.Net;
using Portofolio.AppModels.Models;
using Microsoft.EntityFrameworkCore;
namespace Portofolio.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        private readonly UserManager<User> _userManager;

        private readonly IRepository<UsersInProject> _uipRepository;

        private readonly IImageService _imageServices;

        private readonly IRepository<UserLink> _userLinksRepository;

        private readonly IRepository<LinkType> _linkTypesRepository;

        private readonly IEmailParserFromModelAsync<HTMLModel> _htmlEmailParser;

        private readonly IMailService _mailServices;

        public UserController(SignInManager<User> signInManager, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository, BaseImageServices<User> imageServices, BaseRepository<UserLink> userLinksRepository, BaseRepository<LinkType> linkTypesRepository, IEmailParserFromModelAsync<HTMLModel> htmlEmailParser, IMailService mailServices)
        {
            _uipRepository = uipRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _imageServices = imageServices;
            _userLinksRepository = userLinksRepository;
            _linkTypesRepository = linkTypesRepository;
            _htmlEmailParser = htmlEmailParser;
            _mailServices = mailServices;
        }
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            user.UserLinks = await _userLinksRepository.FindCollectionByCondition(ul => ul.UserId == user.Id);
            var linkTypes = await _linkTypesRepository.GetAll();
            return View(new UserProfileViewModel
            {
                User = user,
                LinkTypes = linkTypes
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitLogin(LoginViewModel loginData)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginData.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.UserName, loginData.Password, true, false);
                    if (result.Succeeded)
                    {
                        if (loginData.ReturnUrl == null)
                        {
                            return RedirectToAction(controllerName: "Dashboard", actionName: nameof(DashboardController.Index));
                        }
                        else
                        {
                            return Redirect(loginData.ReturnUrl);
                        }
                    }
                    else
                    {
                        TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                        {
                            Message = "Please make sure email and password are correct",
                            CssClass = ResultMsgViewModel.CssClassFailed
                        });
                    }
                }
            }
            ModelState.AssignTempDataWithErrors(TempData);
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UserProfileViewModel profileViewModel, IFormFile userImageFile)
        {
            string imagePath = string.Empty;
            if (userImageFile != null)
            {
                try
                {
                    _imageServices.ValidateImgExtension(userImageFile);
                    imagePath = await _imageServices.UploadImgAsync(userImageFile);
                    await _userManager.EditUserWithImageAsync(profileViewModel.User, imagePath, _imageServices);
                    await _userLinksRepository.EditUserLinks(profileViewModel.Links, profileViewModel.LinksIds);
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
            else
            {
                await _userManager.EditUserAsync(profileViewModel.User);
                await _userLinksRepository.EditUserLinks(profileViewModel.Links, profileViewModel.LinksIds);
            }
            return RedirectToAction(nameof(Profile));
        }

        public async Task<IActionResult> ProfileImage(int id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync((user) => user.Id == id);
            var imageModel = await _imageServices.GetImageAsync(user.ImagePath);
            return File(imageModel.FileStream, imageModel.ContentType);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(controllerName: "Home", actionName: nameof(HomeController.Index));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var linkTypes = await _linkTypesRepository.GetAll();
            return View(new CreateProfileViewModel
            {
                User = user,
                LinkTypes = linkTypes
            });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProfileViewModel createProfileViewModel, IFormFile userImageFile)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(Create));
            }
            try
            {
                var newUser = await _userManager.CreateUserAsync(createProfileViewModel);
                await _userLinksRepository.CreateUserLinks(createProfileViewModel.Links, createProfileViewModel.LinkTypeIds, newUser.Id);
                if (userImageFile != null)
                {
                    _imageServices.ValidateImgExtension(userImageFile);
                    newUser.ImagePath = await _imageServices.UploadImgAsync(userImageFile);
                    await _userManager.UpdateAsync(newUser);
                }
            }
            catch (CustomException ex)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = ex.Message,
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "User Created Successfuly!",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(nameof(Create));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PasswordChange()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(new ChangePasswordViewModel
            {
                User = user
            });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordChange(ChangePasswordViewModel changePasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(PasswordChange));
            }
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
            if (!result.Succeeded)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = result.ToString(),
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Password Changed Successfuly!",
                CssClass = ResultMsgViewModel.CssClassSuccess
            });
            return RedirectToAction(nameof(PasswordChange));
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(ForgotPassword));
            }
            else if (user == null)
            {
                TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                {
                    Message = "Please make sure you entered a valid email",
                    CssClass = ResultMsgViewModel.CssClassFailed
                });
                return RedirectToAction(nameof(ForgotPassword));
            }
            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.ActionLink(nameof(ResetPassword), "User", new { token = resetToken, email = user.Email }, Request.Scheme);
            var mailRequest = await _htmlEmailParser.ParseAsync(new HTMLModel()
            {
                Path = "templates/resetpassword.html",
                PlaceHolders = new string[] { "[href]" },
                PlaceHolderValues = new string[] { $" href={callback}" },
                ToEmail = user.Email
            });
            await _mailServices.SendEmailAsync(mailRequest);
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            return View("NewPasswordForm", new NewPasswordViewModel
            {
                Token = token,
                Email = email
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewPassword(NewPasswordViewModel newPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AssignTempDataWithErrors(TempData);
                return RedirectToAction(nameof(ResetPassword), new { token = newPasswordViewModel.Token, email = newPasswordViewModel.Email });
            }
            var user = await _userManager.FindByEmailAsync(newPasswordViewModel.Email);
            var result = await _userManager.ResetPasswordAsync(user, newPasswordViewModel.Token, newPasswordViewModel.Password);
            if (result.Succeeded)
            {
                var loginResult = await _signInManager.PasswordSignInAsync(user.UserName, newPasswordViewModel.Password, true, false);
                if (loginResult.Succeeded)
                {
                    return RedirectToAction(actionName: nameof(DashboardController.Index), controllerName: "Dashboard");
                }
                else
                {
                    TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
                    {
                        Message = "Login failed, please try again" + result.ToString(),
                        CssClass = ResultMsgViewModel.CssClassFailed
                    });
                    return RedirectToAction(nameof(ResetPassword), new { token = newPasswordViewModel.Token, email = newPasswordViewModel.Email });
                }
            }
            TempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = "Password change failed, please try again" + result.ToString(),
                CssClass = ResultMsgViewModel.CssClassFailed
            });
            return RedirectToAction(nameof(ResetPassword), new { token = newPasswordViewModel.Token, email = newPasswordViewModel.Email });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
