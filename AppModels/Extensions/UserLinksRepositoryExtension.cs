using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using System.Collections.Generic;
using System.Linq;
namespace Portofolio.AppModels.Extensions
{
    public static class UserLinksRepositoryExtensions
    {
        public async static Task EditUserLinks(this BaseRepository<UserLink> repository, ICollection<string> links, ICollection<int> ids)
        {
            for (int i = 0; i < links.Count; i++)
            {
                var newUserLink = new UserLink
                {
                    Link = links.ElementAt(i),
                    Id = ids.ElementAt(i)
                };
                await repository.Edit(newUserLink);
            }
        }
        public async static Task CreateUserLinks(this BaseRepository<UserLink> repository, ICollection<string> links, ICollection<int> linkTypeIds, int userId)
        {
            for (int i = 0; i < links.Count; i++)
            {
                string link = " ";
                if (links.ElementAt(i) != string.Empty && links.ElementAt(i) != null)
                {
                    link = links.ElementAt(i);
                }
                var newUserLink = new UserLink
                {
                    UserId = userId,
                    TypeId = linkTypeIds.ElementAt(i),
                    Link = link
                };
                await repository.Create(newUserLink);
            }
        }
    }
}