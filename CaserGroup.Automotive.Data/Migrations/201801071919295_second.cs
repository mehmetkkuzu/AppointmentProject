namespace CaserGroup.Automotive.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointment", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Appointment", "CostumerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointment", "CostumerId", c => c.Int(nullable: false));
            DropColumn("dbo.Appointment", "CustomerId");
        }
    }
}
