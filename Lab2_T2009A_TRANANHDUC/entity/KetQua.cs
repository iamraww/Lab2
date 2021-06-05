namespace Lab2_T2009A_TRANANHDUC.entity
{
    public class KetQua
    {
        public string MaTranDau { get; set; }
        public string KetQuaDau { get; set; } // bỏ cái này đi
        public int GhiBanDoi1 { get; set; }
        public int GhiBanDoi2 { get; set; }
        public int Status { get; set; }  // 0. Chưa thi đấu 1. Đang Thi đấu. 2. Kết thúc. -1. Hủy
    }
}