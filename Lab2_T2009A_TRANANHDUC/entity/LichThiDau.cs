using System;

namespace Lab2_T2009A_TRANANHDUC.entity
{
    public class LichThiDau
    {
        public string MaTranDau { get; set; }
        public string MaDoi1 { get; set; }
        public string TenDoi1 { get; set; }
        public string TenDoi2 { get; set; }
        public string MaDoi2 { get; set; }
        public DateTime CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
        public string NgayThiDau { get; set; }
        public string GioThiDau { get; set; }
        public string SanThiDau { get; set; }
        public int Status { get; set; }  // 0. Chưa thi đấu 1. Đang Thi đấu. 2. Kết thúc. -1. Hủy
    }
}