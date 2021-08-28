using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.Models
{
    public class ProjectTool
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get; set;}

        [Required]
        [StringLength(maximumLength:255)]

        public string ToolUsed{get; set;}

        public DateTime CreatedAt {get; set;}

        public DateTime UpdatedAt {get; set;}

        [Required]
        public int ProjectId {get; set;}

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty(nameof(Project.Tools))]
        public virtual Project AssociatedProject {get; set;}

    }
}