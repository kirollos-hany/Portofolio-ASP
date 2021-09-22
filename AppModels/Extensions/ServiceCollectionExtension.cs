using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portofolio.AppModels.Repositories;
using Portofolio.Models;
using Portofolio.AppModels.Services;
using Portofolio.AppModels.Models;
using Portofolio.Database;
using Microsoft.AspNetCore.Identity;
using System;
namespace Portofolio.AppModels.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(BaseRepository<Contact>), typeof(ContactRepository));
            services.AddTransient(typeof(BaseRepository<ContactStatus>), typeof(ContactStatusRepository));
            services.AddTransient(typeof(BaseRepository<Service>), typeof(ServicesRepository));
            services.AddTransient(typeof(BaseRepository<Project>), typeof(ProjectsRepository));
            services.AddTransient(typeof(BaseRepository<RequestedService>), typeof(RequestedServicesRepository));
            services.AddTransient(typeof(BaseRepository<UsersInProject>), typeof(UIPRepository));
            services.AddTransient(typeof(BaseRepository<UserLink>), typeof(UserLinksRepository));
            services.AddTransient(typeof(BaseRepository<LinkType>), typeof(LinkTypesRepository));
            services.AddTransient(typeof(BaseRepository<ProjectFeedback>), typeof(ProjectFeedbacksRepository));
            services.AddTransient(typeof(BaseRepository<ProjectImage>), typeof(ProjectImagesRepository));
            services.AddTransient(typeof(BaseRepository<ProjectLink>), typeof(ProjectLinksRepository));
            services.AddTransient(typeof(BaseRepository<ProjectType>), typeof(ProjectTypeRepository));
            services.AddTransient(typeof(BaseRepository<UserRoleInProject>), typeof(UserRoleInProjectRepository));
            services.AddTransient(typeof(BaseRepository<ProjectLog>), typeof(ProjectLogsRepository));
            services.AddTransient(typeof(BaseRepository<ContactLog>), typeof(ContactLogsRepository));
            services.AddTransient(typeof(BaseRepository<ServicesLog>), typeof(ServicesLogsRepository));
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(BasePaginator<Project>), typeof(ProjectsPaginator));
            services.AddTransient(typeof(BasePaginator<User>), typeof(MembersPaginator));
            services.AddTransient(typeof(BasePaginator<Service>), typeof(ServicesPaginator));
            services.AddTransient(typeof(IMailService), typeof(MailService));
            services.AddTransient(typeof(IEmailParserFromModelAsync<HTMLWithModel<Contact>>), typeof(HTMLWithContactEmailParser));
            services.AddTransient(typeof(IEmailParserFromModelAsync<HTMLModel>), typeof(HTMLEmailParser));
            services.AddTransient(typeof(IImageServices), typeof(ImageServices));
            services.AddIdentity<User, UserRole>().AddEntityFrameworkStores<PortofolioDbContext>().AddRoles<UserRole>().AddDefaultTokenProviders();
        }

        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireUppercase = false;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = new TimeSpan(0, 5, 0);
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/user/login");
                options.LogoutPath = new Microsoft.AspNetCore.Http.PathString("/user/logout");
            });
        }
    }
}