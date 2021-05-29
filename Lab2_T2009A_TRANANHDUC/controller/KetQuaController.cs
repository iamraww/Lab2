using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.model;
using Lab2_T2009A_TRANANHDUC.service;


namespace Lab2_T2009A_TRANANHDUC.controller

{
    public class KetQuaController
    {
        private KetQua _ketQua = new KetQua();
        private KetQuaModel _ketQuaModel = new KetQuaModel();
        private Check _check = new Check();
        private KetQuaThiDauService _ketQuaThiDauService = new KetQuaThiDauService();
        public void XemKetQua()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(
                $"|{"Mã trận đấu",20}{"",10}|{"Trận",20}{"",10}|{"Kết quả",20}{"",10}|");
            _ketQuaModel.XemKetQua();
            Console.WriteLine("Bạn muốn cập nhật kết quả không(Y/N)?");
            string q = Console.ReadLine();
            if (q == "y" || q == "Y")
            {
                Console.WriteLine("Nhập mã trận đấu: ");
                string maTranDau = Console.ReadLine();
                if (_check.CheckMaTranDau(maTranDau))
                {
                    if (_check.CheckTrangThai(maTranDau))
                    {
                        Console.WriteLine("Nhập kết quả trận đấu");
                        _ketQua.KetQuaDau = Console.ReadLine();
                        if (_ketQuaThiDauService.ThemKetQuaService(_ketQua, maTranDau) != null)
                        {
                            Console.WriteLine($"Cập nhật thành công kết quả trận đấu số {maTranDau}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không thể cập nhật kết quả");
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy mã đội bóng");
                }
            }

        }

        public void ThemKetQua()
        {
            
        }
    }
}