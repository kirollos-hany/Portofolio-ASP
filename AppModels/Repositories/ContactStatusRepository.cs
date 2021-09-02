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
            await dbContext.ContactStatuses.AddAsync(entity);
            return entity;
        }

        public async override Task<ContactStatus> Delete(ContactStatus entity)
        {
            dbContext.ContactStatuses.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<ContactStatus>> DeleteCollection(ICollection<ContactStatus> entities)
        {
            dbContext.ContactStatuses.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<ContactStatus> Edit(ContactStatus entity)
        {
            ContactStatus contactStatus = await dbContext.ContactStatuses.Include(contactStatus => contactStatus.Contacts).FirstOrDefaultAsync(cs => cs.Id == entity.Id);
            contactStatus.UpdatedAt = DateTime.Now;
            contactStatus.Status = entity.Status;
            await SaveChanges();
            return entity;
        }

        public async override Task<ContactStatus> FindByCondition(Expression<Func<ContactStatus, bool>> expression)
        {
            return await dbContext.ContactStatuses.Include(cs => cs.Contacts).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<ContactStatus>> FindCollectionByCondition(Expression<Func<ContactStatus, bool>> expression)
        {
            return await Task.Run(() => dbContext.ContactStatuses.Include(cs => cs.Contacts).Where(expression).ToList());
        }

        public async override Task<ICollection<ContactStatus>> GetAll()
        {
            return await Task.Run(() => dbContext.ContactStatuses.Include(cs => cs.Contacts).ToList());
        }

        public async override Task<ContactStatus> GetById(int id)
        {
            return await dbContext.ContactStatuses.Include(cs => cs.Contacts).FirstOrDefaultAsync(cs => cs.Id == id);
        }

    }
}