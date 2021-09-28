using Portofolio.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
namespace Portofolio.ViewModels
{
    public class ServiceDetailsDashboardVM : DashboardViewModel
    {
        public Service Service { get; set; }

        public int Id;

        [Required]
        public string Name { get; set; }

        public IFormFile ServiceImage { get; set; }

        [Required]

        public string Description { get; set; }
    }
}