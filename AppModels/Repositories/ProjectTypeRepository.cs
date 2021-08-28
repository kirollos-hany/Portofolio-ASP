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
    public class ProjectTypeRepository : BaseRepository<ProjectType>
    {
        public ProjectTypeRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectType> Create(ProjectType entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.ProjectTypes.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectType> Delete(ProjectType entity)
        {
            dbContext.ProjectTypes.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectType> Edit(ProjectType entity)
        {
            var projectType = await dbContext.ProjectTypes.FindAsync(entity.Id);
            projectType.Type = entity.Type;
            projectType.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectType> FindByCondition(Expression<Func<ProjectType, bool>> expression)
        {
            return await dbContext.ProjectTypes.Include(pt => pt.Projects).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<ProjectType>> FindCollectionByCondition(Expression<Func<ProjectType, bool>> expression)
        {
            return await dbContext.ProjectTypes.Include(pt => pt.Projects).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectType>> GetAll()
        {
            return await dbContext.ProjectTypes.ToListAsync();
        }

        public async override Task<ProjectType> GetById(int id)
        {
            return await dbContext.ProjectTypes.Include(pt => pt.Projects).FirstOrDefaultAsync(pt => pt.Id == id);
        }
    }
}