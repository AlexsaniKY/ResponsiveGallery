namespace ResponsiveGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GalleryImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Title = c.String(maxLength: 64),
                        ImageURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TagGalleryImages",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        GalleryImage_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.GalleryImage_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.GalleryImages", t => t.GalleryImage_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.GalleryImage_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagGalleryImages", "GalleryImage_Id", "dbo.GalleryImages");
            DropForeignKey("dbo.TagGalleryImages", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TagGalleryImages", new[] { "GalleryImage_Id" });
            DropIndex("dbo.TagGalleryImages", new[] { "Tag_Id" });
            DropTable("dbo.TagGalleryImages");
            DropTable("dbo.Tags");
            DropTable("dbo.GalleryImages");
        }
    }
}
