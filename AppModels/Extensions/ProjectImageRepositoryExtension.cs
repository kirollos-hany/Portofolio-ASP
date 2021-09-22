using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using System.Linq;
using Portofolio.AppModels.Services;
using Microsoft.AspNetCore.Http;
using static Portofolio.AppModels.Utils.Constants;
namespace Portofolio.AppModels.Extensions
{
    public static class ProjectImageRepositoryExtension
    {
        public async static Task CreateFromCollection(this IRepository<ProjectImage> repository, int projectId, IFormFileCollection images, IImageServices imageService)
        {
            for(int i = 0; i < images.Count; i++)
            {
                imageService.ValidateImgExtension(images.ElementAt(i));
                string imagePath = await imageService.UploadImgAsync(images.ElementAt(i));
                await repository.Create(new ProjectImage{
                    ProjectId = projectId,
                    ImagePath = imagePath
                });
                await imageService.ResizeImg(imagePath, ProjectImageSize);
            }
        }
    }
}