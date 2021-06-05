using System;

namespace Lab2_T2009A_TRANANHDUC.entity
{
    public class DoiBong
    {
        public string MaDoiBong { get; set; }
        public string TenDoiBong { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public int DiemSo { get; set; }
        public string HuanLuyenVien { get; set; }
    }
}