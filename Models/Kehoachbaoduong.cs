using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EquipmentManager.Models
{
    public class Kehoachbaoduong
    {
        public int Id { get; set; }
        [Display(Name= "Thiết bị")]        
        public int ThietbiId { get; set; }
        [Display(Name = "Kế hoạch bảo dưỡng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime KHBD { get; set; }
        [Display(Name = "Ngày bảo dưỡng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<DateTime> NgayBD { get; set; }
        //public int Lanbaoduong { get; set; }
        [Display(Name = "Mô tả")]
        public string Noidung { get; set; }
        [Display(Name = "Ghi chú")]
        public string Ghichu { get; set; }
        public virtual Thietbi Thietbi { get; set; }
    }
}