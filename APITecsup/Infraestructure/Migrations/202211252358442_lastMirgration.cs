namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastMirgration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "IsEnable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Productoes", "CreatedON", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "CreatedON");
            DropColumn("dbo.Productoes", "IsEnable");
        }
    }
}
