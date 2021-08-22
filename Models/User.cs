using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace Portofolio.Models
{
    [Table("users")]
    public class User : IdentityUser<int>
    {
        public User()
        {
            UserLinks = new HashSet<UserLink>();
            UsersInProjects = new HashSet<UsersInProject>();
        }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public DateTime CreatedAt {get; set;}

        [Required]
        public DateTime UpdatedAt {get; set;}

        [InverseProperty(nameof(UserLink.User))]
        public virtual ICollection<UserLink> UserLinks { get; set; }
        [InverseProperty(nameof(UsersInProject.User))]
        public virtual ICollection<UsersInProject> UsersInProjects { get; set; }
    }
}