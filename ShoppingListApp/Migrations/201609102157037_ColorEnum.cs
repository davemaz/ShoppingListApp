namespace ShoppingListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorEnum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ShoppingLists", "Color", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShoppingLists", "Color", c => c.String());
        }
    }
}
