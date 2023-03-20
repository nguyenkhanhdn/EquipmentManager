using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Department
    {
        [Display(Name = "Mã phòng ban")]
        public int Id { get; set; }
        [Required(ErrorMessage="Tên phòng ban không được để trống.")]
        [Display(Name="Tên phòng ban")]
        public string DepartmentName { get; set; }
        public string Leader { get; set; }
        public string Note{ get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}