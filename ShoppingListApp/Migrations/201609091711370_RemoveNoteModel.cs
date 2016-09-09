namespace ShoppingListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNoteModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingListItems", "ShoppingListId", "dbo.ShoppingLists");
            DropIndex("dbo.ShoppingListItems", new[] { "ShoppingListId" });
            DropTable("dbo.ShoppingListItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ShoppingListItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShoppingListId = c.Int(nullable: false),
                        Contents = c.String(),
                        Note = c.String(),
                        IsChecked = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ShoppingListItems", "ShoppingListId");
            AddForeignKey("dbo.ShoppingListItems", "ShoppingListId", "dbo.ShoppingLists", "Id", cascadeDelete: true);
        }
    }
}
