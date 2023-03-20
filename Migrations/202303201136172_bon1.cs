namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bon1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
        }
    }
}
