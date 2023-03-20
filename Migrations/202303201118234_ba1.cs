namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        Leader = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        Address = c.String(),
                        DepartmentId = c.String(),
                        Phone = c.String(),
                        Note = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
