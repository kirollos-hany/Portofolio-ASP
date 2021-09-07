using System.Collections.Generic;
using Portofolio.Models;
using System.Threading.Tasks;
using Portofolio.AppModels.Repositories;
namespace Portofolio.AppModels.Extensions
{
    public static class RequestedServiceRepoExtensions
    {
        public async static Task CreateFromIds(this IRepository<RequestedService> repository, ICollection<int> servicesIds, int contactId)
        {
            foreach (int id in servicesIds)
            {
                var request = new RequestedService{
                    ContactId = contactId,
                    ServiceId = id,
                };
                await repository.Create(request);
            }
        }
    }
}