using Portofolio.Models;
using System.Collections.Generic;
namespace Portofolio.ViewModels
{
    public class ServicesLogsVM : DashboardViewModel
    {
        public ICollection<ServicesLog> Logs { get; set; }
    }
}