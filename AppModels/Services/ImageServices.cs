using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Portofolio.AppModels.Exceptions;
using System;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Services
{
    public class ImageServices : IImageService
    {
        private readonly List<string> imageExtensions;
        private readonly string rootPath;
        public ImageServices(IWebHostEnvironment env)
        {
            imageExtensions = new List<string>();
            imageExtensions.Add(".jpg");
            imageExtensions.Add(".jpeg");
            imageExtensions.Add(".png");
            imageExtensions.Add(".webp");
            imageExtensions.Add(".bmp");
            rootPath = env.ContentRootPath;
        }

        public string GetImgExtension(string imagePath)
        {
            FileInfo fi = new FileInfo(imagePath);
            return fi.Extension.ToLower();
        }

        public async Task<string> UploadImg(IFormFile file, string directoryPath)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string extension = fileInfo.Extension;
            string fileName = string.Concat(Guid.NewGuid().ToString(), extension);
            string fullPath = Path.Combine(rootPath, directoryPath, fileName);
            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }
            return Path.Combine(directoryPath, fileName);
        }

        public void ValidateImgExtension(IFormFile file)
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

        public async Task DeleteImg(string imagePath)
        {
            await Task.Run(() => File.Delete(imagePath));
        }
    }
}