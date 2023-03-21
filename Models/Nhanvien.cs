using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Nhanvien
    {
        public int Id { get; set; }
        [Display(Name="Họ và tên")]
        [Required(ErrorMessage ="Họ và tên không được để trống.")]
        public string Hoten { get; set; }
        [Display(Name = "Phòng ban")]
        [Required(ErrorMessage = "Phòng ban không được để trống.")]
        
        [ForeignKey("Phongban")]
        public Nullable<int> PhongbanId { get; set; }
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public string Gioitinh { get; set; }
        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        public DateTime Ngaysinh { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống.")]
        public string Diachi { get; set; }
        [Display(Name = "Điện thoại")]
        [Required(ErrorMessage = "Điện thoại không được để trống.")]
        public string Dienthoai { get; set; }
        [Display(Name = "Ghi chú")]
        public string Ghichu{ get; set; }        
        public virtual Phongban Phongban { get; set; }
    }
}