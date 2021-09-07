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
            await _dbContext.RequestedServices.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<RequestedService> Delete(RequestedService entity)
        {
            _dbContext.RequestedServices.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<RequestedService>> DeleteCollection(ICollection<RequestedService> entities)
        {
           _dbContext.RequestedServices.RemoveRange(entities);
           await SaveChanges();
           return entities;
        }

        public async override Task<RequestedService> Edit(RequestedService entity)
        {
            RequestedService rs = await _dbContext.RequestedServices.FindAsync(entity.Id);
            rs.ServiceId = entity.ServiceId;
            rs.ContactId = entity.ContactId;
            rs.UpdatedAt = DateTime.Now;
            return entity;
        }

        public async override Task<RequestedService> FindByCondition(Expression<Func<RequestedService, bool>> expression)
        {
            return await _dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<RequestedService>> FindCollectionByCondition(Expression<Func<RequestedService, bool>> expression)
        {
            return await Task.Run(()=>_dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).Where(expression).ToHashSet());
        }

        public async override Task<ICollection<RequestedService>> GetAll()
        {
            return await Task.Run(()=>_dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).ToHashSet());
        }

        public async override Task<RequestedService> GetById(int id)
        {
            return await _dbContext.RequestedServices.Include(rs => rs.AssociatedContact).Include(rs => rs.AssociatedService).FirstOrDefaultAsync(rs => rs.Id == id);
        }
    }
}