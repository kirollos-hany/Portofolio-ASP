using Portofolio.Models;
using System.Collections.Generic;
namespace Portofolio.ViewModels
{
    public class ServicesDashboardVM : DashboardViewModel
    {
        public ICollection<Service> Services {get; set;}
    }
}