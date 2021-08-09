using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portofolio.Models
{
    [Table("users")]
    public partial class User
    {
        public User()
        {
            UserLinks = new HashSet<UserLink>();
            UsersInProjects = new HashSet<UsersInProject>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(320)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string ImagePath { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }

        [InverseProperty(nameof(UserLink.User))]
        public virtual ICollection<UserLink> UserLinks { get; set; }
        [InverseProperty(nameof(UsersInProject.User))]
        public virtual ICollection<UsersInProject> UsersInProjects { get; set; }
    }
}
