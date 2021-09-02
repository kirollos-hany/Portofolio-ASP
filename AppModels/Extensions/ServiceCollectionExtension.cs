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
        public static void AddServicesToContainer(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseRepository<Contact>), typeof(ContactRepository));
            services.AddScoped(typeof(BaseRepository<ContactStatus>), typeof(ContactStatusRepository));
            services.AddScoped(typeof(BaseRepository<Service>), typeof(ServicesRepository));
            services.AddScoped(typeof(BaseRepository<Project>), typeof(ProjectsRepository));
            services.AddScoped(typeof(BaseImageServices<User>), typeof(UserImageServices));
            services.AddScoped(typeof(BaseImageServices<Project>), typeof(ProjectImageServices));
            services.AddScoped(typeof(BaseRepository<RequestedService>), typeof(RequestedServicesRepository));
            services.AddScoped(typeof(BaseRepository<UsersInProject>), typeof(UIPRepository));
            services.AddScoped(typeof(BaseRepository<UserLink>), typeof(UserLinksRepository));
            services.AddScoped(typeof(BaseRepository<LinkType>), typeof(LinkTypesRepository));
            services.AddScoped(typeof(BaseRepository<ProjectFeedback>), typeof(ProjectFeedbacksRepository));
            services.AddScoped(typeof(BaseRepository<ProjectImage>), typeof(ProjectImagesRepository));
            services.AddScoped(typeof(BaseRepository<ProjectLink>), typeof(ProjectLinksRepository));
            services.AddScoped(typeof(BaseRepository<ProjectType>), typeof(ProjectTypeRepository));
            services.AddScoped(typeof(BaseRepository<UserRoleInProject>), typeof(UserRoleInProjectRepository));
            services.AddScoped(typeof(BaseRepository<ImageType>), typeof(ImageTypeRepository));
            services.AddScoped(typeof(IMailService), typeof(MailService));
            services.AddScoped(typeof(IEmailParserFromModelAsync<HTMLWithModel<Contact>>), typeof(HTMLWithContactEmailParser));
            services.AddScoped(typeof(IEmailParserFromModelAsync<HTMLModel>), typeof(HTMLEmailParser));
            services.AddIdentity<User, UserRole>().AddEntityFrameworkStores<PortofolioDbContext>().AddDefaultTokenProviders();
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