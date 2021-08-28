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
    public class ProjectImagesRepository : BaseRepository<ProjectImage>
    {
        public ProjectImagesRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectImage> Create(ProjectImage entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.ProjectImages.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectImage> Delete(ProjectImage entity)
        {
            dbContext.ProjectImages.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectImage> Edit(ProjectImage entity)
        {
            var pi = await dbContext.ProjectImages.FindAsync(entity.Id);
            pi.ImagePath = entity.ImagePath;
            pi.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectImage> FindByCondition(Expression<Func<ProjectImage, bool>> expression)
        {
            return await dbContext.ProjectImages.Include(pi => pi.Type).FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ProjectImage>> FindCollectionByCondition(Expression<Func<ProjectImage, bool>> expression)
        {
            return await dbContext.ProjectImages.Include(pi => pi.Type).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectImage>> GetAll()
        {
            return await dbContext.ProjectImages.Include(pi => pi.Type).ToListAsync();
        }

        public async override Task<ProjectImage> GetById(int id)
        {
            return await dbContext.ProjectImages.Include(pi => pi.Type).FirstOrDefaultAsync(pi => pi.Id == id);
        }
    }
}