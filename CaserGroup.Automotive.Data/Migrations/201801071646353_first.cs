namespace CaserGroup.Automotive.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CostumerId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plate = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        ModelYear = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicle");
            DropTable("dbo.Customer");
            DropTable("dbo.Appointment");
        }
    }
}
