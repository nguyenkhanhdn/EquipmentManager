namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nam1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kehoachbaoduongs", "NgayBD", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kehoachbaoduongs", "NgayBD", c => c.DateTime(nullable: false));
        }
    }
}
