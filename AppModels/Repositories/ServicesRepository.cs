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
            await dbContext.Services.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Service> Delete(Service entity)
        {
            await Task.Run(() => dbContext.Services.Remove(entity));
            await SaveChanges();
            return entity;
        }

        public async override Task<Service> Edit(Service entity)
        {
            Service service = await dbContext.Services.FirstOrDefaultAsync(service => entity.Id == service.Id);
            service.ServiceDescription = entity.ServiceDescription;
            service.ServiceImage = entity.ServiceImage;
            service.ServiceName = entity.ServiceName;
            await SaveChanges();
            return entity;
        }

        public async override Task<Service> FindByCondition(Expression<Func<Service, bool>> expression)
        {
            return await dbContext.Services.Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<List<Service>> FindCollectionByCondition(Expression<Func<Service, bool>> expression)
        {
            return await dbContext.Services.Where(expression).ToListAsync();
        }

        public async override Task<List<Service>> GetAll()
        {
            return await dbContext.Services.ToListAsync();
        }

        public async override Task<Service> GetById(int id)
        {
            return await dbContext.Services.FindAsync(id);
        }

    }
}