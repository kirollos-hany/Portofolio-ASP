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
    public class ProjectsRepository : BaseRepository<Project>
    {
        public ProjectsRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<Project> Create(Project entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.Projects.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Project> Delete(Project entity)
        {
            dbContext.Projects.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<Project> Edit(Project entity)
        {
            Project project = await dbContext.Projects.Include(project => project.Type)
            .Include(project => project.ProjectImages)
            .Include(project => project.ProjectLinks)
            .Include(project => project.ProjectFeedbacks)
            .Include(Project => Project.UsersInProjects).ThenInclude(usersInProject => usersInProject.User)
            .Include(project => project.UsersInProjects).ThenInclude(usersInProject => usersInProject.Role)
            .FirstOrDefaultAsync(project => project.Id == entity.Id);
            project.Title = entity.Title;
            project.Description = entity.Description;
            project.UpdatedAt = DateTime.Now;
            project.TypeId = entity.TypeId;
            await SaveChanges();
            return entity;
        }

        public async override Task<Project> FindByCondition(Expression<Func<Project, bool>> expression)
        {
            return await dbContext.Projects.Include(project => project.Type)
            .Include(project => project.ProjectFeedbacks).Include(project => project.ProjectImages)
            .Include(project => project.Tools)
            .Include(project => project.ProjectLinks)
            .Include(Project => Project.UsersInProjects).ThenInclude(usersInProject => usersInProject.User)
            .Include(project => project.UsersInProjects).ThenInclude(usersInProject => usersInProject.Role)
            .Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<Project>> FindCollectionByCondition(Expression<Func<Project, bool>> expression)
        {
            return await dbContext.Projects.Include(project => project.Type)
            .Include(project => project.ProjectFeedbacks).Include(project => project.ProjectImages)
            .Include(project => project.ProjectLinks)
            .Include(project => project.Tools)
            .Include(Project => Project.UsersInProjects).ThenInclude(usersInProject => usersInProject.User)
            .Include(project => project.UsersInProjects).ThenInclude(usersInProject => usersInProject.Role)
            .Where(expression).ToListAsync();
        }

        public async override Task<ICollection<Project>> GetAll()
        {
            return await dbContext.Projects.Include(project => project.Type)
            .Include(project => project.ProjectFeedbacks).Include(project => project.ProjectImages)
            .Include(project => project.ProjectLinks)
            .Include(project => project.Tools)
            .Include(Project => Project.UsersInProjects).ThenInclude(usersInProject => usersInProject.User)
            .Include(project => project.UsersInProjects).ThenInclude(usersInProject => usersInProject.Role)
            .ToListAsync();
        }

        public async override Task<Project> GetById(int id)
        {
            return await dbContext.Projects.Include(project => project.Type)
            .Include(project => project.ProjectFeedbacks).Include(project => project.ProjectImages)
            .Include(project => project.ProjectLinks)
            .Include(project => project.Tools)
            .Include(Project => Project.UsersInProjects).ThenInclude(usersInProject => usersInProject.User)
            .Include(project => project.UsersInProjects).ThenInclude(usersInProject => usersInProject.Role)
            .FirstOrDefaultAsync(project => project.Id == id);
        }
    }
}