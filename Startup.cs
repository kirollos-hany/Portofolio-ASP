using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portofolio.Database;
using Portofolio.Models;
using Microsoft.EntityFrameworkCore;
using Portofolio.AppModels.Repositories;
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
                options.UseMySql(connString, ServerVersion.AutoDetect(connString));
                options.EnableSensitiveDataLogging();
            });
            services.AddScoped(typeof(BaseRepository<Contact>), typeof(ContactRepository));
            services.AddScoped(typeof(BaseRepository<ContactStatus>), typeof(ContactStatusRepository));
            services.AddScoped(typeof(BaseRepository<Service>), typeof(ServicesRepository));
            services.AddScoped(typeof(BaseRepository<Project>), typeof(ProjectsRepository));
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

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
