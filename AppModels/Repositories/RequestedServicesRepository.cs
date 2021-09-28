using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Portofolio.Database;
using Portofolio.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.AppModels.Repositories
{
    public class RequestedServicesRepository : BaseRepository
    {

        public RequestedServicesRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<RequestedService> Create(RequestedService rs)
        {
            rs.CreatedAt = DateTime.Now;
            rs.UpdatedAt = DateTime.Now;
            await _dbContext.RequestedServices.AddAsync(rs);
            return rs;
        }

        public async Task CreateFromIds(ICollection<int> servicesIds, int contactId)
        {
            foreach (int id in servicesIds)
            {
                var request = new RequestedService{
                    ContactId = contactId,
                    ServiceId = id,
                };
                await Create(request);
            }
        }

        // public async override Task<RequestedService> GetById(int id)
        // {
        //     return await _dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).FirstOrDefaultAsync(rs => rs.Id == id);
        // }
    }
}