using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Thietbi
    {
        public int Id { get; set; }
        [Display(Name = "Tên thiết bị")]
        [Required(ErrorMessage ="Tên thiết bị không được để trống.")]
        public string Tenthietbi { get; set; }
        [Display(Name = "Ngày SX")]
        [Required(ErrorMessage = "Ngày sản xuất không được để trống.")]
        public string NgaySX { get; set; }
        [Display(Name = "Nhà SX")]
        [Required(ErrorMessage = "Nhà sản xuất không được để trống.")]
        public string NhaSX { get; set; }
        [Display(Name = "Hạn dùng")]
        [Required(ErrorMessage = "Hạn dùng không được để trống.")]
        public int Handung { get; set; }
        [Display(Name = "Ngày mua")]
        [Required(ErrorMessage = "Ngày mua không được để trống.")]
        public DateTime Ngaymua { get; set; }
        [Display(Name = "Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị tính không được để trống.")]
        public string DVT { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống.")]
        public int Soluong { get; set; }
        [Display(Name = "Tình trạng")]
        [Required(ErrorMessage = "Tình trạng không được để trống.")]
        public string Tinhtrang { get; set; }

    }
}