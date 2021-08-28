using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portofolio.Database;
using Portofolio.Models;
using Microsoft.EntityFrameworkCore;
using Portofolio.AppModels.Repositories;
using Portofolio.AppModels.Services;
using Microsoft.AspNetCore.Identity;
using Portofolio.AppModels.Models;
using System;
namespace Portofolio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            string connString = Configuration.GetConnectionString("PortofolioMySQLConn");
            services.AddDbContextPool<PortofolioDbContext>(options =>
            {
                options.UseMySql(connString, ServerVersion.AutoDetect(connString), dbOptions =>
                {
                    dbOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                });
                options.EnableSensitiveDataLogging();

            });
            services.AddScoped(typeof(BaseRepository<Contact>), typeof(ContactRepository));
            services.AddScoped(typeof(BaseRepository<ContactStatus>), typeof(ContactStatusRepository));
            services.AddScoped(typeof(BaseRepository<Service>), typeof(ServicesRepository));
            services.AddScoped(typeof(BaseRepository<Project>), typeof(ProjectsRepository));
            services.AddScoped(typeof(IImageService), typeof(ImageServices));
            services.AddScoped(typeof(BaseRepository<RequestedService>), typeof(RequestedServicesRepository));
            services.AddScoped(typeof(BaseRepository<UsersInProject>), typeof(UIPRepository));
            services.AddScoped(typeof(BaseRepository<UserLink>), typeof(UserLinksRepository));
            services.AddScoped(typeof(BaseRepository<LinkType>), typeof(LinkTypesRepository));
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddScoped(typeof(IMailService), typeof(MailService));
            services.AddScoped(typeof(IEmailParserFromModelAsync<HTMLWithModel<Contact>>), typeof(HTMLWithContactEmailParser));
            services.AddScoped(typeof(IEmailParserFromModelAsync<HTMLModel>), typeof(HTMLEmailParser));
            services.AddIdentity<User, UserRole>().AddEntityFrameworkStores<PortofolioDbContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireUppercase = false;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            });
            services.ConfigureApplicationCookie(options => {
                options.ExpireTimeSpan = new TimeSpan(0,5,0);
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/user/login");
                options.LogoutPath = new Microsoft.AspNetCore.Http.PathString("/user/logout");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.Use(async (cxt, next) => {
                await next();
                if(cxt.Response.StatusCode == 404)
                {
                    cxt.Request.Path = "/errors/error404";
                    await next();
                }
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
