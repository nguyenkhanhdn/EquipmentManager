namespace EquipmentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mot : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            //DropIndex("dbo.Employees", new[] { "DepartmentId" });
            CreateTable(
                "dbo.Baoduongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThietbiId = c.Int(nullable: false),
                        Lanbaoduong = c.Int(nullable: false),
                        Noidung = c.String(),
                        Ngaybaoduong = c.DateTime(nullable: false),
                        Nhanvien = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kehoachbaoduongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThietbiId = c.Int(nullable: false),
                        Lanbaoduong = c.Int(nullable: false),
                        Noidung = c.String(),
                        Ngaybaoduong = c.DateTime(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Thietbis", t => t.ThietbiId, cascadeDelete: true)
                .Index(t => t.ThietbiId);
            
            CreateTable(
                "dbo.Thietbis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tenthietbi = c.String(nullable: false),
                        NgaySX = c.String(nullable: false),
                        NhaSX = c.String(nullable: false),
                        Handung = c.Int(nullable: false),
                        Ngaymua = c.DateTime(nullable: false),
                        DVT = c.String(nullable: false),
                        Soluong = c.Int(nullable: false),
                        Tinhtrang = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hoten = c.String(nullable: false),
                        PhongbanId = c.Int(nullable: false),
                        Gioitinh = c.String(nullable: false),
                        Ngaysinh = c.DateTime(nullable: false),
                        Diachi = c.String(nullable: false),
                        Dienthoai = c.String(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phongbans", t => t.PhongbanId, cascadeDelete: true)
                .Index(t => t.PhongbanId);
            
            CreateTable(
                "dbo.Phongbans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tenphong = c.String(nullable: false),
                        Phutrach = c.String(nullable: false),
                        Dienthoai = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            //DropTable("dbo.Departments");
            //DropTable("dbo.Employees");
            //DropTable("dbo.Equipments");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.Equipments",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            EquipmentName = c.String(nullable: false),
            //            Manufacturer = c.String(nullable: false),
            //            Provider = c.String(nullable: false),
            //            CategoryId = c.Int(nullable: false),
            //            DateOfManufacture = c.DateTime(nullable: false),
            //            PeriodOfUse = c.Int(nullable: false),
            //            Warehouse = c.String(nullable: false),
            //            Unit = c.String(nullable: false),
            //            Quantity = c.Int(nullable: false),
            //            Status = c.String(),
            //            Note = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Employees",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Fullname = c.String(),
            //            Address = c.String(),
            //            Phone = c.String(),
            //            Note = c.String(),
            //            DepartmentId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            ////CreateTable(
            //    "dbo.Departments",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            DepartmentName = c.String(nullable: false),
            //            Leader = c.String(),
            //            Note = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Nhanviens", "PhongbanId", "dbo.Phongbans");
            DropForeignKey("dbo.Kehoachbaoduongs", "ThietbiId", "dbo.Thietbis");
            DropIndex("dbo.Nhanviens", new[] { "PhongbanId" });
            DropIndex("dbo.Kehoachbaoduongs", new[] { "ThietbiId" });
            DropTable("dbo.Phongbans");
            DropTable("dbo.Nhanviens");
            DropTable("dbo.Thietbis");
            DropTable("dbo.Kehoachbaoduongs");
            DropTable("dbo.Baoduongs");
            //CreateIndex("dbo.Employees", "DepartmentId");
            //AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "Id");
        }
    }
}
