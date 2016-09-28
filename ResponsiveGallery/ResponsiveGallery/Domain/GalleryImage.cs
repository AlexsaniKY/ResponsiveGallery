using ResponsiveGallery.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResponsiveGallery.Domain
{
    public class GalleryImage : IDbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Active { get; set; }

        [MaxLength(64, ErrorMessage = "Title must be at maximum 64 characters long")]
        public string Title { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public GalleryImage() { }

        public GalleryImage(bool active, string title, string imageurl, ICollection<Tag> tags)
        {
            Active = active;
            Title = title;
            ImageURL = imageurl;
            Tags = tags;
        }
    }
}