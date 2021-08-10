using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Services
{
    public interface IImageService
    {
        void ValidateImgExtension(IFormFile file);

        Task<string> UploadImg(IFormFile file, string directoryName);
    }
}