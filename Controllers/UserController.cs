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
using Portofolio.AppModels.Models;
using static Portofolio.AppModels.Utils.Constants;
using static Portofolio.AppModels.Utils.KeyConstants;
using System.Linq;
namespace Portofolio.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        private readonly UserManager<User> _userManager;

        private readonly IRepository<UsersInProject> _uipRepository;

        private readonly IImageServices _imageServices;

        private readonly IRepository<UserLink> _userLinksRepository;

        private readonly IRepository<LinkType> _linkTypesRepository;

        private readonly IEmailParserFromModelAsync<HTMLModel> _htmlEmailParser;

        private readonly IMailService _mailServices;

        private readonly IRepository<Contact> _contactsRepository;

        private readonly IDisplayOutput _outputDisplayer;

        public UserController(IDisplayOutput outputDisplayer, BaseRepository<Contact> contactsRepository, SignInManager<User> signInManager, UserManager<User> userManager, BaseRepository<UsersInProject> uipRepository, IImageServices imageServices, BaseRepository<UserLink> userLinksRepository, BaseRepository<LinkType> linkTypesRepository, IEmailParserFromModelAsync<HTMLModel> htmlEmailParser, IMailService mailServices)
        {
            _uipRepository = uipRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _imageServices = imageServices;
            _userLinksRepository = userLinksRepository;
            _linkTypesRepository = linkTypesRepository;
            _htmlEmailParser = htmlEmailParser;
            _mailServices = mailServices;
            _contactsRepository = contactsRepository;
            _outputDisplayer = outputDisplayer;
        }
        public IActionResult Login(string returnUrl = null)
        {
            ViewData[ReturnUrlKey] = returnUrl;
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.UsersInProjects = await _uipRepository.FindCollectionByCondition((uip) => uip.UserId == user.Id);
            user.UserLinks = await _userLinksRepository.FindCollectionByCondition(ul => ul.UserId == user.Id);
            var linkTypes = await _linkTypesRepository.GetAll();
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == ContactStatuses.Pending.ToString()).Count();
            return View(new UserProfileViewModel
            {
                PendingContactsCount = pendingContactsCount,
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
                        _outputDisplayer.DisplayOutput(ViewData, false, "Email or password is invalid");
                    }
                }
            }
            ModelState.AssignViewDataWithErrors(ViewData);
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UserProfileViewModel profileViewModel, IFormFile userImageFile)
        {
            string imagePath = string.Empty;
            if (userImageFile != default(IFormFile))
            {
                try
                {
                    _imageServices.ValidateImgExtension(userImageFile);
                    imagePath = await _imageServices.UploadImgAsync(userImageFile);
                    await _userManager.EditUserWithImageAsync(profileViewModel.User, imagePath, _imageServices);
                    await _userLinksRepository.EditUserLinks(profileViewModel.Links, profileViewModel.LinksIds);
                    await _imageServices.ResizeImg(imagePath, UserImageSize);
                }
                catch (CustomException ex)
                {
                    _outputDisplayer.DisplayOutput(ViewData, false, ex.Message);
                }
            }
            else
            {
                await _userManager.EditUserAsync(profileViewModel.User);
                await _userLinksRepository.EditUserLinks(profileViewModel.Links, profileViewModel.LinksIds);
            }
            return RedirectToAction(nameof(Profile));
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
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == ContactStatuses.Pending.ToString()).Count();
            return View(new CreateProfileViewModel
            {
                PendingContactsCount = pendingContactsCount,
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
                ModelState.AssignViewDataWithErrors(ViewData);
                return RedirectToAction(nameof(Create));
            }
            try
            {
                var newUser = await _userManager.CreateUserAsync(createProfileViewModel);
                await _userLinksRepository.CreateUserLinks(createProfileViewModel.Links, createProfileViewModel.LinkTypeIds, newUser.Id);
                if (userImageFile != default(IFormFile))
                {
                    _imageServices.ValidateImgExtension(userImageFile);
                    newUser.ImagePath = await _imageServices.UploadImgAsync(userImageFile);
                    await _userManager.UpdateAsync(newUser);
                    await _imageServices.ResizeImg(newUser.ImagePath, UserImageSize);
                }
            }
            catch (CustomException ex)
            {
                _outputDisplayer.DisplayOutput(ViewData, false, ex.Message);
            }
            _outputDisplayer.DisplayOutput(ViewData, true, "User created successfuly");
            return RedirectToAction(nameof(Create));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PasswordChange()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var pendingContactsCount = (await _contactsRepository.GetAll()).Where((contact) => contact.Status.Status == ContactStatuses.Pending.ToString()).Count();
            return View(new ChangePasswordViewModel
            {
                PendingContactsCount = pendingContactsCount,
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
                ModelState.AssignViewDataWithErrors(ViewData);
                return RedirectToAction(nameof(PasswordChange));
            }
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
            if (!result.Succeeded)
            {
                _outputDisplayer.DisplayOutput(ViewData, false, result.ToString());
            }
            _outputDisplayer.DisplayOutput(ViewData, true, "Password change is successful");
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
                ModelState.AssignViewDataWithErrors(ViewData);
                return RedirectToAction(nameof(ForgotPassword));
            }
            else if (user == default(User))
            {
                _outputDisplayer.DisplayOutput(ViewData, false, "Email invalid");
                return RedirectToAction(nameof(ForgotPassword));
            }
            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.ActionLink(nameof(ResetPassword), "User", new { token = resetToken, email = user.Email }, Request.Scheme);
            var mailRequest = await _htmlEmailParser.ParseAsync(new HTMLModel()
            {
                Path = PasswordResetHtmlTemplatePath,
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
                ModelState.AssignViewDataWithErrors(ViewData);
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
                    _outputDisplayer.DisplayOutput(ViewData, false, "Login failed, " + result.ToString());
                    return RedirectToAction(nameof(ResetPassword), new { token = newPasswordViewModel.Token, email = newPasswordViewModel.Email });
                }
            }
            _outputDisplayer.DisplayOutput(ViewData, false, "Password change failed, " + result.ToString());
            return RedirectToAction(nameof(ResetPassword), new { token = newPasswordViewModel.Token, email = newPasswordViewModel.Email });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
