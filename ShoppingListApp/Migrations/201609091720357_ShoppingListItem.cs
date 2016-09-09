namespace ShoppingListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppingListItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingListItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShoppingListId = c.Int(nullable: false),
                        Contents = c.String(),
                        Note = c.String(),
                        Priority = c.Int(nullable: false),
                        IsChecked = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingListId, cascadeDelete: true)
                .Index(t => t.ShoppingListId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingListItems", "ShoppingListId", "dbo.ShoppingLists");
            DropIndex("dbo.ShoppingListItems", new[] { "ShoppingListId" });
            DropTable("dbo.ShoppingListItems");
        }
    }
}
