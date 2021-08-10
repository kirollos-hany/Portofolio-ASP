using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portofolio.Models
{
    [Table("projects")]
    [Index(nameof(TypeId), Name = "TypeId")]
    public partial class Project
    {
        public Project()
        {
            ProjectFeedbacks = new HashSet<ProjectFeedback>();
            ProjectImages = new HashSet<ProjectImage>();
            ProjectLinks = new HashSet<ProjectLink>();
            UsersInProjects = new HashSet<UsersInProject>();
            Tools = new HashSet<ProjectTool>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(ProjectType.Projects))]
        public virtual ProjectType Type { get; set; }
        [InverseProperty(nameof(ProjectFeedback.Project))]
        public virtual ICollection<ProjectFeedback> ProjectFeedbacks { get; set; }
        [InverseProperty(nameof(ProjectImage.Project))]
        public virtual ICollection<ProjectImage> ProjectImages { get; set; }
        [InverseProperty(nameof(ProjectLink.Project))]
        public virtual ICollection<ProjectLink> ProjectLinks { get; set; }
        [InverseProperty(nameof(UsersInProject.Project))]
        public virtual ICollection<UsersInProject> UsersInProjects { get; set; }

        [InverseProperty(nameof(ProjectTool.AssociatedProject))]
        public virtual ICollection<ProjectTool> Tools{get; set;}
    }
}
