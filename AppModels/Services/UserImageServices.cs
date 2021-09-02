using Portofolio.Models;
using Microsoft.AspNetCore.Hosting;

namespace Portofolio.AppModels.Services
{
    public class UserImageServices : BaseImageServices<User>
    {
        public UserImageServices(IWebHostEnvironment env) : base(env)
        {

        }
        protected override string DirectoryName { get => "Images/Users"; }
    }
}