using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace Portofolio.AppModels.Extensions
{
    public static class UIPRepositoryExtension
    {
        public async static Task CreateFromCollection(this IRepository<UsersInProject> uipRepository, int projectId, ICollection<string> usersNRolesIds, char delimiter)
        {
            foreach (var str in usersNRolesIds)
            {
                string[] splitStr = str.Split(delimiter);
                await uipRepository.Create(new UsersInProject
                {
                    ProjectId = projectId,
                    UserId = Convert.ToInt32(splitStr[1]),
                    RoleId = Convert.ToInt32(splitStr[0])
                });
            }
        }

        public async static Task EditFromCollection(this IRepository<UsersInProject> uipRepository, ICollection<UsersInProject> usersInProjects, ICollection<string> usersNRolesIds, char delimiter)
        {
            for (int i = 0; i < usersNRolesIds.Count; i++)
            {
                string[] splitStr = usersNRolesIds.ElementAt(i).Split(delimiter);
                await uipRepository.Edit(new UsersInProject
                {
                    Id = usersInProjects.ElementAt(i).Id,
                    UserId = Convert.ToInt32(splitStr[1]),
                    RoleId = Convert.ToInt32(splitStr[0])
                });
            }
        }
    }
}