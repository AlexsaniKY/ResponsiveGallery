namespace ResponsiveGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnametotags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tags", "TagName", c => c.String(nullable: false, maxLength: 64));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tags", "TagName");
        }
    }
}
