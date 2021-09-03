using Portofolio.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
namespace Portofolio.ViewModels
{
    public class ServicesDashboardVM : DashboardViewModel
    {
        public int Id;
        public ICollection<Service> Services { get; set; }

        public string Name { get; set; }

        public IFormFile ServiceImage { get; set; }

        public string Description { get; set; }
    }
}