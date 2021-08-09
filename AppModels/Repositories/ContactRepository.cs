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
        private readonly BaseRepository<ContactStatus> contactStatusRepository;
        public ContactRepository(PortofolioDbContext dbContext, BaseRepository<ContactStatus> contactStatusRepository) : base(dbContext)
        {
            this.contactStatusRepository = contactStatusRepository;
        }

        public async override Task<Contact> Create(Contact entity)
        {
            ContactStatus cs = await contactStatusRepository.FindByCondition(cs => cs.Status == "Pending");
            entity.CreatedAt = DateTime.Now;
            entity.StatusId = cs.Id;
            await dbContext.Contacts.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Contact> Delete(Contact entity)
        {
            await Task.Run(() => dbContext.Contacts.Remove(entity));
            await SaveChanges();
            return entity;
        }

        public async override Task<Contact> Edit(Contact entity)
        {
            Contact contact = await dbContext.Contacts.Include(contact => contact.Status).FirstOrDefaultAsync(contact => contact.Id == entity.Id);
            contact.StatusId = entity.StatusId;
            contact.Status = entity.Status;
            contact.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<Contact> FindByCondition(Expression<Func<Contact, bool>> expression)
        {
            return await dbContext.Contacts.Include(Contact => Contact.Status).FirstOrDefaultAsync(expression);
        }

        public async override Task<List<Contact>> FindCollectionByCondition(Expression<Func<Contact, bool>> expression)
        {
            return await Task.Run(() => dbContext.Contacts.Include(contact => contact.Status).Where(expression).ToList());
        }

        public async override Task<List<Contact>> GetAll()
        {
            return await Task.Run(() => dbContext.Contacts.Include(contact => contact.Status).ToList<Contact>());
        }

        public async override Task<Contact> GetById(int id)
        {
            return await dbContext.Contacts.Include(contact => contact.Status).FirstOrDefaultAsync(contact => contact.Id == id);
        }

    }
}