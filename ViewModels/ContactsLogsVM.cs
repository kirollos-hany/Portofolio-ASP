using Portofolio.Models;
using System.Collections.Generic;
namespace Portofolio.ViewModels
{
    public class ContactsLogsVM : DashboardViewModel
    {
        public ICollection<ContactLog> Logs { get; set; }
    }
}