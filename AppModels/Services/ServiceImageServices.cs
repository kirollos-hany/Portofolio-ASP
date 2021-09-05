
using Microsoft.AspNetCore.Hosting;
using Portofolio.Models;
namespace Portofolio.AppModels.Services
{
    public class ServiceImageServices : BaseImageServices<Service>
    {
        public ServiceImageServices(IWebHostEnvironment env) : base(env)
        {
        }

        protected override string DirectoryName => "Images/Services";
    }
}