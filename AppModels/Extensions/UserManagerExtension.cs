using System.Threading.Tasks;
using Portofolio.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Portofolio.AppModels.Services;
using System;
using Portofolio.ViewModels;
using Portofolio.AppModels.Exceptions;
namespace Portofolio.AppModels.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<User> EditUserAsync(this UserManager<User> userManager, User newUserData)
        {
            var user = await Task.Run(() => userManager.Users.Where(user => user.Id == newUserData.Id).FirstOrDefault());
            user.UserName = newUserData.UserName;
            user.Email = newUserData.Email;
            user.PhoneNumber = newUserData.PhoneNumber;
            user.Specialization = newUserData.Specialization;
            user.UpdatedAt = DateTime.Now;
            await userManager.UpdateAsync(user);
            return user;
        }

        public static async Task<User> EditUserWithImageAsync(this UserManager<User> userManager, User newUserData, string imagePath, IImageService imageServices)
        {
            var user = await Task.Run(() => userManager.Users.Where(user => user.Id == newUserData.Id).FirstOrDefault());
            user.UserName = newUserData.UserName;
            user.Email = newUserData.Email;
            user.PhoneNumber = newUserData.PhoneNumber;
            user.Specialization = newUserData.Specialization;
            user.UpdatedAt = DateTime.Now;
            imageServices.DeleteImg(user.ImagePath);
            user.ImagePath = imagePath;
            await userManager.UpdateAsync(user);
            return user;
        }

        public static async Task<User> CreateUserAsync(this UserManager<User> userManager, CreateProfileViewModel userProfileViewModel)
        {
            var newUser = new User
            {
                UserName = userProfileViewModel.User.UserName,
                Email = userProfileViewModel.User.Email,
                Specialization = userProfileViewModel.User.Specialization,
                PhoneNumber = userProfileViewModel.User.PhoneNumber,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now
            };
            var result = await userManager.CreateAsync(newUser, userProfileViewModel.Password);
            if (!result.Succeeded)
            {
                throw new CustomException(result.ToString());
            }
            return newUser;
        }
    }
}