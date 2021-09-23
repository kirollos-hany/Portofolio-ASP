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
            await _dbContext.ProjectImages.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectImage> Delete(ProjectImage entity)
        {
            _dbContext.ProjectImages.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<ProjectImage>> DeleteCollection(ICollection<ProjectImage> entities)
        {
            _dbContext.ProjectImages.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<ProjectImage> Edit(ProjectImage entity)
        {
            var pi = await _dbContext.ProjectImages.FindAsync(entity.Id);
            pi.ImagePath = entity.ImagePath;
            pi.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectImage> FindByCondition(Expression<Func<ProjectImage, bool>> expression)
        {
            return await _dbContext.ProjectImages.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ProjectImage>> FindCollectionByCondition(Expression<Func<ProjectImage, bool>> expression)
        {
            return await _dbContext.ProjectImages.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectImage>> GetAll()
        {
            return await _dbContext.ProjectImages.ToListAsync();
        }

        public async override Task<ProjectImage> GetById(int id)
        {
            return await _dbContext.ProjectImages.FindAsync(id);
        }
    }
}