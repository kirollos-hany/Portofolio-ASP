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
    public class ServicesLogsRepository : BaseRepository<ServicesLog>
    {
        public ServicesLogsRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ServicesLog> Create(ServicesLog entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _dbContext.ServicesLogs.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public override Task<ServicesLog> Delete(ServicesLog entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<ServicesLog>> DeleteCollection(ICollection<ServicesLog> entities)
        {
            throw new NotImplementedException();
        }

        public override Task<ServicesLog> Edit(ServicesLog entity)
        {
            throw new NotImplementedException();
        }

        public async override Task<ServicesLog> FindByCondition(Expression<Func<ServicesLog, bool>> expression)
        {
            return await _dbContext.ServicesLogs.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ServicesLog>> FindCollectionByCondition(Expression<Func<ServicesLog, bool>> expression)
        {
            return await _dbContext.ServicesLogs.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ServicesLog>> GetAll()
        {
            return await _dbContext.ServicesLogs.ToListAsync();
        }

        public async override Task<ServicesLog> GetById(int id)
        {
            return await _dbContext.ServicesLogs.FindAsync(id);
        }
    }
}