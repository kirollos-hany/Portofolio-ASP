using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Portofolio.Models
{
    [Table("ServicesLogs")]
    public class ServicesLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public Nullable<int> ServiceId { get; set; }
        
        public Nullable<int> UserId { get; set; }

        [Required(ErrorMessage = "Action is required")]
        public string Action { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Service name is required")]
        public string ServiceName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ServicesLogs")]
        public User User { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("Logs")]
        public Service Service { get; set; }
    }
}