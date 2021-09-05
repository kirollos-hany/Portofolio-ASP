using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using System.Linq;
using Portofolio.AppModels.Services;
using Microsoft.AspNetCore.Http;
namespace Portofolio.AppModels.Extensions
{
    public static class ProjectImageRepositoryExtension
    {
        public async static Task CreateFromCollection(this BaseRepository<ProjectImage> repository, int projectId, int imgTypeId, IFormFileCollection images,BaseImageServices<Project> imageService)
        {
            for(int i = 0; i < images.Count; i++)
            {
                imageService.ValidateImgExtension(images.ElementAt(i));
                string imagePath = await imageService.UploadImgAsync(images.ElementAt(i));
                await repository.Create(new ProjectImage{
                    ProjectId = projectId,
                    TypeId = imgTypeId,
                    ImagePath = imagePath
                });
            }
        }
    }
}