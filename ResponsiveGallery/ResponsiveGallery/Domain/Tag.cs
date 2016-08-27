using ResponsiveGallery.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveGallery.Domain
{
    public class Tag : IDbEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public ICollection<GalleryImage> Images { get; set; }
    }
}