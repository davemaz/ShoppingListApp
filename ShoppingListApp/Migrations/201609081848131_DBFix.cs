namespace ShoppingListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShoppingLists");
        }
    }
}
