using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        [Display(Name="Tên thiết bị")]
        [Required(ErrorMessage = "Tên thiết bị không được để trống")]
        public string EquipmentName { get; set; }
        [Display(Name = "Nhà sản xuất")]
        [Required(ErrorMessage = "Nhà sản xuất không được để trống")]
        public string Manufacturer { get; set; }
        [Display(Name = "Nhà cung cấp")]
        [Required(ErrorMessage = "Nhà cung cấp không được để trống")]
        public string Provider { get; set; }
        [Display(Name = "Loại thiết bị")]
        [Required(ErrorMessage = "Loại thiết bị không được để trống")]
        public int CategoryId { get; set; }
        [Display(Name = "Ngày sản xuất")]
        [Required(ErrorMessage = "Ngày sản xuất không được để trống")]
        public DateTime DateOfManufacture { get; set; }
        [Display(Name = "Thời hạn sử dụng")]
        [Required(ErrorMessage = "Thời hạn sử dụng không được để trống")]
        public int PeriodOfUse { get; set; }
        [Display(Name = "Kho lưu")]
        [Required(ErrorMessage = "Kho lưu không được để trống")]
        public string Warehouse { get; set; }
        [Display(Name = "Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị tính không được để trống")]
        public string Unit { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public int Quantity { get; set; }
        [Display(Name = "Tình trạng sử dụng")]
        public string Status { get; set; }
        [Display(Name = "Số lượng")]
        public string Note { get; set; }
    }
}