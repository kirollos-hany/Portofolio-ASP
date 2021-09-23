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
    public class ServicesRepository : BaseRepository<Service>
    {
        public ServicesRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<Service> Create(Service entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.Services.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Service> Delete(Service entity)
        {
            _dbContext.Services.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<Service>> DeleteCollection(ICollection<Service> entities)
        {
            _dbContext.Services.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<Service> Edit(Service entity)
        {
            Service service = await _dbContext.Services.FirstOrDefaultAsync(service => entity.Id == service.Id);
            service.ServiceDescription = entity.ServiceDescription;
            service.ServiceImage = entity.ServiceImage;
            service.ServiceName = entity.ServiceName;
            service.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<Service> FindByCondition(Expression<Func<Service, bool>> expression)
        {
            return await _dbContext.Services.Include(service => service.Requests).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<Service>> FindCollectionByCondition(Expression<Func<Service, bool>> expression)
        {
            return await _dbContext.Services.Include(service => service.Requests).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<Service>> GetAll()
        {
            return await _dbContext.Services.Include(service => service.Requests).ToListAsync();
        }

        public async override Task<Service> GetById(int id)
        {
            return await _dbContext.Services.Include(service => service.Requests).FirstOrDefaultAsync(service => service.Id == id);
        }

    }
}