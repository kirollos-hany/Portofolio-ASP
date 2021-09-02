using Portofolio.Models;
using Microsoft.AspNetCore.Hosting;

namespace Portofolio.AppModels.Services
{
    public class ProjectImageServices : BaseImageServices<Project>
    {
        public ProjectImageServices(IWebHostEnvironment env) : base(env)
        {

        }
        protected override string DirectoryName { get => "Images/Projects"; }
    }
}