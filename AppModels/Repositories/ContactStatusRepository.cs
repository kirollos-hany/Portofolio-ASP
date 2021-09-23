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
    public class ContactStatusRepository : BaseRepository<ContactStatus>
    {
        public ContactStatusRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ContactStatus> Create(ContactStatus entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.ContactStatuses.AddAsync(entity);
            return entity;
        }

        public async override Task<ContactStatus> Delete(ContactStatus entity)
        {
            _dbContext.ContactStatuses.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<ContactStatus>> DeleteCollection(ICollection<ContactStatus> entities)
        {
            _dbContext.ContactStatuses.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<ContactStatus> Edit(ContactStatus entity)
        {
            ContactStatus contactStatus = await _dbContext.ContactStatuses.Include(contactStatus => contactStatus.Contacts).FirstOrDefaultAsync(cs => cs.Id == entity.Id);
            contactStatus.UpdatedAt = DateTime.Now;
            contactStatus.Status = entity.Status;
            await SaveChanges();
            return entity;
        }

        public async override Task<ContactStatus> FindByCondition(Expression<Func<ContactStatus, bool>> expression)
        {
            return await _dbContext.ContactStatuses.Include(cs => cs.Contacts).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<ContactStatus>> FindCollectionByCondition(Expression<Func<ContactStatus, bool>> expression)
        {
            return await _dbContext.ContactStatuses.Include(cs => cs.Contacts).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ContactStatus>> GetAll()
        {
            return await _dbContext.ContactStatuses.Include(cs => cs.Contacts).ToListAsync();
        }

        public async override Task<ContactStatus> GetById(int id)
        {
            return await _dbContext.ContactStatuses.Include(cs => cs.Contacts).FirstOrDefaultAsync(cs => cs.Id == id);
        }

    }
}