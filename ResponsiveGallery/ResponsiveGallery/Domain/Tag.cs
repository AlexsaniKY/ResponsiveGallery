using ResponsiveGallery.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResponsiveGallery.Domain
{
    public class Tag : IDbEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Tag must be at most 64 characters long")]
        public string TagName { get; set; }

        public ICollection<GalleryImage> Images { get; set; }
    }
}