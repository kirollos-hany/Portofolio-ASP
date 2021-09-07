
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using Portofolio.AppModels.Exceptions;
using System.Collections.Generic;
using Portofolio.AppModels.Models;
namespace Portofolio.AppModels.Services
{
    public abstract class BaseImageServices<T> : IImageService where T : class
    {
        protected List<string> imageExtensions;
        protected string rootPath;
        protected abstract string DirectoryName { get; }

        public BaseImageServices(IWebHostEnvironment env)
        {
            imageExtensions = new List<string>();
            imageExtensions.Add(".jpg");
            imageExtensions.Add(".jpeg");
            imageExtensions.Add(".png");
            imageExtensions.Add(".webp");
            imageExtensions.Add(".bmp");
            rootPath = env.ContentRootPath;
        }
        public virtual void DeleteImg(string imagePath)
        {
            if(imagePath.StartsWith("~"))
            {
                return;
            }
            File.Delete(imagePath);
        }

        public virtual string GetImgExtension(string imagePath)
        {
            FileInfo fi = new FileInfo(imagePath);
            return fi.Extension.ToLower();
        }

        public async virtual Task<string> UploadImgAsync(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string extension = fileInfo.Extension;
            string fileName = string.Concat(Guid.NewGuid().ToString(), extension);
            string fullPath = Path.Combine(rootPath, DirectoryName, fileName);
            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }
            return Path.Combine(DirectoryName, fileName);
        }

        public virtual void ValidateImgExtension(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            if (!imageExtensions.Contains(fileInfo.Extension.ToLower()))
            {
                string supportedExtensions = string.Empty;
                foreach (string ext in imageExtensions)
                {
                    supportedExtensions = string.Concat(supportedExtensions, ext, "\n");
                }
                throw new CustomException($"Image extension not supported.\nSupported extensions:\n{supportedExtensions}");
            }
        }

        public async virtual Task<ImageModel> GetImageAsync(string imagePath)
        {
            return new ImageModel
            {
                FileStream = await File.ReadAllBytesAsync(imagePath),
                ContentType = "image/" + GetImgExtension(imagePath)
            };
        }
    }
}