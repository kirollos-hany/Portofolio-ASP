using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portofolio.AppModels.Extensions
{
    public static class ProjectLinksRepositoryExtension
    {
        public async static Task CreateFromCollection(this BaseRepository<ProjectLink> repository, int projectId, ICollection<int> linkTypesIds, ICollection<string> links)
        {
            for (int i = 0; i < links.Count; i++)
            {
                await repository.Create(new ProjectLink
                {
                    ProjectId = projectId,
                    TypeId = linkTypesIds.ElementAt(i),
                    Link = links.ElementAt(i) == null ? "#" : links.ElementAt(i)
                });
            }
        }

        public async static Task EditFromCollection(this BaseRepository<ProjectLink> repository, ICollection<int> linksIds, ICollection<string> links)
        {
            for(int i = 0; i < linksIds.Count; i++)
            {
                await repository.Edit(new ProjectLink
                {
                    Id = linksIds.ElementAt(i),
                    Link = links.ElementAt(i)
                });
            }
        }
    }
}