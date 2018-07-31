namespace DeepSpaceDatabaseZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SpaceObjects", "URL", c => c.String(nullable: false));
            AlterColumn("dbo.SpaceObjects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.SpaceObjects", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.SpaceObjects", "Distance", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SpaceObjects", "Distance", c => c.String());
            AlterColumn("dbo.SpaceObjects", "Category", c => c.String());
            AlterColumn("dbo.SpaceObjects", "Name", c => c.String());
            AlterColumn("dbo.SpaceObjects", "URL", c => c.String());
        }
    }
}
