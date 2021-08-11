using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceName { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string ServiceDescription { get; set; }

        [Required]
        public string ServiceImage { get; set; }

        [InverseProperty(nameof(RequestedService.AssociatedService))]
        public virtual ICollection<RequestedService> Requests { get; set; }

    }
}