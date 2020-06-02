namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Quanity", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.OrderItems", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Quantity", c => c.String());
            AlterColumn("dbo.OrderItems", "Price", c => c.String());
            DropColumn("dbo.OrderItems", "Quanity");
        }
    }
}
