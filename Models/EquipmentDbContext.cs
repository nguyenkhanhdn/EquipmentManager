using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class EquipmentDbContext:DbContext
    {
        public EquipmentDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Thietbi> Thietbis { get; set; }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Phongban> Phongbans { get; set; }
        public DbSet<Kehoachbaoduong> Kehoachbaoduongs { get; set; }
        public DbSet<Baoduong> Baoduongs { get; set; }
    }
}