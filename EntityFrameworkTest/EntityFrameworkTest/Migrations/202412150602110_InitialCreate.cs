namespace EntityFrameworkTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfigSettings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ConfigModel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConfigSettings");
        }
    }
}
