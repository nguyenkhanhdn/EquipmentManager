using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Phongban
    {
        [Display(Name = "Mã phòng ban")]
        public int Id { get; set; }
        [Required(ErrorMessage="Tên phòng ban không được để trống.")]
        [Display(Name="Tên phòng ban")]
        public string Tenphong { get; set; }
        [Display(Name = "Người phụ trách")]
        [Required(ErrorMessage = "Người phụ trách không được để trống.")]
        public string Phutrach { get; set; }
        [Required(ErrorMessage = "Điện thoại không được để trống.")]
        [Display(Name = "Điện thoại")]
        public string Dienthoai{ get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}