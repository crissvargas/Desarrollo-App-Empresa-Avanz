namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4migracion : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Sellers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.SellerID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        subTitle = c.String(),
                        datetime = c.String(),
                        type = c.String(),
                        description = c.String(),
                        amount = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
    }
}
