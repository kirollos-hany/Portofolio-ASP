using Portofolio.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace Portofolio.ViewModels
{
    public class ServicesDashboardVM : DashboardViewModel
    {

        public PaginationViewModel<Service> PaginationModel { get; set; }

        [Required]
        public string Name { get; set; }

        public IFormFile ServiceImage { get; set; }

        [Required]

        public string Description { get; set; }

    }
}