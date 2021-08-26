using Portofolio.Models;
using System.Collections.Generic;


namespace Portofolio.ViewModels
{
    public class ProjectsDashboardViewModel : DashboardViewModel
    {
        public ICollection<Project> Projects { get; set; }
    }
}