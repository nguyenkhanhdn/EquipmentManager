using System;

namespace EquipmentManager.Models
{
    public class Baoduong
    {
        public int Id { get; set; }
        public int ThietbiId { get; set; }
        public int Lanbaoduong { get; set; }
        public string Noidung { get; set; }
        public DateTime Ngaybaoduong { get; set; }
        public string Nhanvien { get; set; }
        public string Ghichu { get; set; }
    }
}