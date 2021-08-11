using Portofolio.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Portofolio.ViewModels
{
    public class ContactWithServicesViewModel
    {
        public List<Service> Services { get; set; }

        public Contact Contact { get; set; }

        [Required]
        public List<int> RequestedServicesIds{get; set;}

    }
}