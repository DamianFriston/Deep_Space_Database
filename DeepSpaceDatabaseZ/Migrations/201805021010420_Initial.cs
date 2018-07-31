namespace DeepSpaceDatabaseZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpaceObjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                        Name = c.String(),
                        Magnitude = c.Single(nullable: false),
                        Category = c.String(),
                        Distance = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SpaceObjects");
        }
    }
}
