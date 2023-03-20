using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }

        public Nullable<int> DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}