using ResponsiveGallery.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResponsiveGallery.Infrastructure
{
    public class ResponsiveGalleryContext : DbContext
    {
        public ResponsiveGalleryContext(): base("ResponsiveGalleryContext")
        {
            Database.SetInitializer<ResponsiveGalleryContext>(null);
        }

        public static ResponsiveGalleryContext Create()
        {
            return new ResponsiveGalleryContext();
        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}