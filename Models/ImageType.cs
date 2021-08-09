using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portofolio.Models
{
    [Table("imagetypes")]
    [Index(nameof(ImgType), Name = "ImgType", IsUnique = true)]
    public partial class ImageType
    {
        public ImageType()
        {
            ProjectImages = new HashSet<ProjectImage>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ImgType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }

        [InverseProperty(nameof(ProjectImage.Type))]
        public virtual ICollection<ProjectImage> ProjectImages { get; set; }
    }
}
