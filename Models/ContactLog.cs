using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Portofolio.Models
{
    [Table("ContactLogs")]
    public class ContactLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> ContactId { get; set; }

        public Nullable<int> UserId { get; set; }

        [Required(ErrorMessage = "Action made is required")]
        public string Action { get; set; }
        
        [Required(ErrorMessage = "Contact name is required")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ContactLogs")]
        public virtual User User { get; set; }

        [ForeignKey(nameof(ContactId))]
        [InverseProperty("Logs")]
        public virtual Contact Contact { get; set; }

    }
}