namespace ShoppingListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ShoppingLists", "Color", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShoppingLists", "Color", c => c.Int(nullable: false));
        }
    }
}
