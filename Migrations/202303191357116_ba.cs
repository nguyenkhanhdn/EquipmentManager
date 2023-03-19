namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentName = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Provider = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DateOfManufacture = c.DateTime(nullable: false),
                        PeriodOfUse = c.Int(nullable: false),
                        Warehouse = c.String(nullable: false),
                        Unit = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Equipments");
        }
    }
}
