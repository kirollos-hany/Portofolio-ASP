using System.Collections.Generic;
using Portofolio.Models;
using System.Threading.Tasks;

namespace Portofolio.AppModels.Repositories
{
    public static class RequestedServiceRepoExtensions
    {
        public async static Task CreateFromIds(this BaseRepository<RequestedService> repository, ICollection<int> servicesIds, int contactId)
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