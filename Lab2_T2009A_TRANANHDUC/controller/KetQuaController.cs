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
                $"|{"Mã trận đấu",20}{"",10}" +
                $"|{"",10}{"Tên Đội 1 - Tên Đội 2",25}" +
                $"|{"",10}{"Ghi bàn đội 1 - Ghi Bàn đội 2",25}");
            _ketQuaModel.XemKetQua();


        }

        public bool UpdateKetQua()
        {
            Console.WriteLine("Nhập mã trận đấu: ");
            _ketQua.MaTranDau = Console.ReadLine();
            if (_check.CheckMaTranDau(_ketQua.MaTranDau))
            {
                    LichThiDau lichThiDau = _check.LayTen(_ketQua.MaTranDau);
                    Console.WriteLine("Nhập kết quả trận đấu");
                    Console.WriteLine($"Nhập bàn thắng của {lichThiDau.TenDoi1}:");
                    _ketQua.GhiBanDoi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Nhập bàn thắng của {lichThiDau.TenDoi2}:");
                    _ketQua.GhiBanDoi2 = Convert.ToInt32(Console.ReadLine());
                    if (_ketQuaModel.ThemKetQua(_ketQua) != null)
                    {
                        Console.WriteLine($"Cập nhật thành công kết quả trận đấu số {_ketQua.MaTranDau}");
                    }
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã trận đấu");
            }
            return false;
        }
    }
}