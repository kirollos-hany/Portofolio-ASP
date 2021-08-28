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
    public class RequestedServicesRepository : BaseRepository<RequestedService>
    {
        public RequestedServicesRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<RequestedService> Create(RequestedService entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.RequestedServices.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<RequestedService> Delete(RequestedService entity)
        {
            dbContext.RequestedServices.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<RequestedService> Edit(RequestedService entity)
        {
            RequestedService rs = await dbContext.RequestedServices.FindAsync(entity.Id);
            rs.ServiceId = entity.ServiceId;
            rs.ContactId = entity.ContactId;
            rs.UpdatedAt = DateTime.Now;
            return entity;
        }

        public async override Task<RequestedService> FindByCondition(Expression<Func<RequestedService, bool>> expression)
        {
            return await dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<RequestedService>> FindCollectionByCondition(Expression<Func<RequestedService, bool>> expression)
        {
            return await dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<RequestedService>> GetAll()
        {
            return await dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).ToListAsync();
        }

        public async override Task<RequestedService> GetById(int id)
        {
            return await dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).FirstOrDefaultAsync(rs => rs.Id == id);
        }
    }
}