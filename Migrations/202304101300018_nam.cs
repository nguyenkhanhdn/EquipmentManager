namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kehoachbaoduongs", "KHBD", c => c.DateTime(nullable: false));
            AddColumn("dbo.Kehoachbaoduongs", "NgayBD", c => c.DateTime(nullable: false));
            DropColumn("dbo.Kehoachbaoduongs", "Lanbaoduong");
            DropColumn("dbo.Kehoachbaoduongs", "Ngaybaoduong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kehoachbaoduongs", "Ngaybaoduong", c => c.DateTime(nullable: false));
            AddColumn("dbo.Kehoachbaoduongs", "Lanbaoduong", c => c.Int(nullable: false));
            DropColumn("dbo.Kehoachbaoduongs", "NgayBD");
            DropColumn("dbo.Kehoachbaoduongs", "KHBD");
        }
    }
}
