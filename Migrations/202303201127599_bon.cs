namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bon : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropColumn("dbo.Employees", "DepartmentId");
            RenameColumn(table: "dbo.Employees", name: "Department_Id", newName: "DepartmentId");
            AlterColumn("dbo.Employees", "DepartmentId", c => c.Int());
            CreateIndex("dbo.Employees", "DepartmentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            AlterColumn("dbo.Employees", "DepartmentId", c => c.String());
            RenameColumn(table: "dbo.Employees", name: "DepartmentId", newName: "Department_Id");
            AddColumn("dbo.Employees", "DepartmentId", c => c.String());
            CreateIndex("dbo.Employees", "Department_Id");
        }
    }
}
