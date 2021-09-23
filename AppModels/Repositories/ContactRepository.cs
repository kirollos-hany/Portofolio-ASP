using System.Threading.Tasks;
using System.Collections.Generic;
using Portofolio.Models;
using Portofolio.Database;
using System.Linq.Expressions;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.AppModels.Repositories
{
    class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<Contact> Create(Contact entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.Contacts.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Contact> Delete(Contact entity)
        {
            _dbContext.Contacts.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<Contact>> DeleteCollection(ICollection<Contact> entities)
        {
            _dbContext.Contacts.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<Contact> Edit(Contact entity)
        {
            Contact contact = await _dbContext.Contacts.Include(contact => contact.Status).FirstOrDefaultAsync(contact => contact.Id == entity.Id);
            contact.StatusId = entity.StatusId;
            contact.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<Contact> FindByCondition(Expression<Func<Contact, bool>> expression)
        {
            return await _dbContext.Contacts.Include(Contact => Contact.Status).Include(contact => contact.RequestedServices).ThenInclude(requestedService => requestedService.AssociatedService).FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<Contact>> FindCollectionByCondition(Expression<Func<Contact, bool>> expression)
        {
            return await _dbContext.Contacts.Include(contact => contact.Status).Include(contact => contact.RequestedServices).ThenInclude(requestedService => requestedService.AssociatedService).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<Contact>> GetAll()
        {
            return await _dbContext.Contacts.Include(contact => contact.Status).Include(contact => contact.RequestedServices).ThenInclude(requestedService => requestedService.AssociatedService).ToListAsync();
        }

        public async override Task<Contact> GetById(int id)
        {
            return await _dbContext.Contacts.Include(contact => contact.Status).Include(contact => contact.RequestedServices).ThenInclude(requestedService => requestedService.AssociatedService).FirstOrDefaultAsync(contact => contact.Id == id);
        }

    }
}