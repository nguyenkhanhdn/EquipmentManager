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
        public int Lanbaoduong { get; set; }
        public string Noidung { get; set; }
        public DateTime Ngaybaoduong { get; set; }
        public string Ghichu { get; set; }
        public virtual Thietbi Thietbi { get; set; }
    }
}