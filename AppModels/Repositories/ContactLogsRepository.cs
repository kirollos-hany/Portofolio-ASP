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
    public class ContactLogsRepository : BaseRepository<ContactLog>
    {
        public ContactLogsRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ContactLog> Create(ContactLog entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _dbContext.ContactLogs.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public override Task<ContactLog> Delete(ContactLog entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<ContactLog>> DeleteCollection(ICollection<ContactLog> entities)
        {
            throw new NotImplementedException();
        }

        public override Task<ContactLog> Edit(ContactLog entity)
        {
            throw new NotImplementedException();
        }

        public async override Task<ContactLog> FindByCondition(Expression<Func<ContactLog, bool>> expression)
        {
           return await _dbContext.ContactLogs.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ContactLog>> FindCollectionByCondition(Expression<Func<ContactLog, bool>> expression)
        {
            return await _dbContext.ContactLogs.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ContactLog>> GetAll()
        {
            return await _dbContext.ContactLogs.ToListAsync();
        }

        public async override Task<ContactLog> GetById(int id)
        {
            return await _dbContext.ContactLogs.FindAsync(id);
        }
    }
}