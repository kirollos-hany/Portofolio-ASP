using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Services
{
    public interface IImageService
    {
        void ValidateImgExtension(IFormFile file);

        Task<string> UploadImgAsync(IFormFile file);

        string GetImgExtension(string imagePath);

        void DeleteImg(string imagePath);
    }
}