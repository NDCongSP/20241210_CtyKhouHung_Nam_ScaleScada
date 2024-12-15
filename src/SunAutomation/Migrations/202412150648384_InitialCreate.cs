namespace SunAutomation.Migrations
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
                        ConfingModel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataLog",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Code = c.String(maxLength: 100),
                        Weight = c.Double(nullable: false),
                        TotalWeight = c.Double(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataLog");
            DropTable("dbo.ConfigSettings");
        }
    }
}
