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
        public DbSet<Equipment> Equipments { get; set; }
    }
}