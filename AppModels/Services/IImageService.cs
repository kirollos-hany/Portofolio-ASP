using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Portofolio.AppModels.Models;
namespace Portofolio.AppModels.Services
{
    public interface IImageService
    {
        void ValidateImgExtension(IFormFile file);

        Task<string> UploadImgAsync(IFormFile file);

        string GetImgExtension(string imagePath);

        void DeleteImg(string imagePath);

        Task<ImageModel> GetImageAsync(string imagePath);
    }
}