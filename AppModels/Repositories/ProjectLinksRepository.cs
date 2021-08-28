using Portofolio.Database;
using Portofolio.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.AppModels.Repositories
{
    public class ProjectLinksRepository : BaseRepository<ProjectLink>
    {
        public ProjectLinksRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectLink> Create(ProjectLink entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.ProjectLinks.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectLink> Delete(ProjectLink entity)
        {
            dbContext.ProjectLinks.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectLink> Edit(ProjectLink entity)
        {
            var pl = await dbContext.ProjectLinks.FindAsync(entity.Id);
            pl.Link = entity.Link;
            pl.UpdatedAt = DateTime.Now;
            pl.TypeId = entity.TypeId;
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectLink> FindByCondition(Expression<Func<ProjectLink, bool>> expression)
        {
            return await dbContext.ProjectLinks.Include(pl => pl.Type).FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ProjectLink>> FindCollectionByCondition(Expression<Func<ProjectLink, bool>> expression)
        {
            return await dbContext.ProjectLinks.Include(pl => pl.Type).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectLink>> GetAll()
        {
            return await dbContext.ProjectLinks.Include(pl => pl.Type).ToListAsync();
        }

        public async override Task<ProjectLink> GetById(int id)
        {
            return await dbContext.ProjectLinks.Include(pl => pl.Type).FirstOrDefaultAsync(pl => pl.Id == id);
        }
    }
}