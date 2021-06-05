using System;
using System.Runtime.InteropServices;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.model;
using Lab2_T2009A_TRANANHDUC.util;

namespace Lab2_T2009A_TRANANHDUC.controller
{
    public class LichThiDauController
    {
        private LichThiDauModel _lichThiDauModel = new LichThiDauModel();
        private LichThiDau _lichThiDau = new LichThiDau();
        private Check _check = new Check();
        public void XemLichThiDau()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(
                $"|{"Mã Trận Đấu",20}{"",10}|{"Ngày Đấu",20}{"",10}|{"Giờ Đấu",20}{"",10}" +
                $"|{"Sân Đấu",20}{"",10}|");
            _lichThiDauModel.XemLichThiDau();
        }

        public void TaoLichThiDau()
        {
            Console.WriteLine("=====Tạo lịch thi đấu=======");
            Console.WriteLine("Mã trận(5 số):");
            _lichThiDau.MaTranDau = Console.ReadLine();
            
            Console.WriteLine("Nhập mã đội 1:");
            _lichThiDau.MaDoi1 = Console.ReadLine();
            if (_check.CheckMaDoiBong(_lichThiDau.MaDoi1))
            {
                Console.WriteLine("Nhập mã đội 2:");
                _lichThiDau.MaDoi2 = Console.ReadLine();
                if (_check.CheckMaDoiBong(_lichThiDau.MaDoi2))
                {
                    Console.WriteLine("Ngày Thi Đấu:");
                    _lichThiDau.NgayThiDau = Console.ReadLine();
                    Console.WriteLine("Giờ Thi Đấu:");
                    _lichThiDau.GioThiDau = Console.ReadLine();
                    Console.WriteLine("Sân Thi Đấu:");
                    _lichThiDau.SanThiDau = Console.ReadLine();
                    if (_lichThiDauModel.TaoLichThiDau(_lichThiDau) != null)
                    {
                        Console.WriteLine($"Thêm thành công trận đấu");
                        Console.WriteLine($"Sẽ diễn ra vào lúc {_lichThiDau.NgayThiDau} {_lichThiDau.GioThiDau}");
                    }
                    else
                    {
                        Console.WriteLine("jashdjasd");
                    }
                }
                else
                {
                    Console.WriteLine("Đội không tồn taị !!");
                }
            }
            else
            {
                Console.WriteLine("Đội không tồn tại");
            }
        }

        public void SuaLichThiDau()
        {
            Console.WriteLine("======Cập nhật thông tin Trận Đấu======");
            Console.WriteLine("Nhập Mã Trận Đấu cần sửa");
            _lichThiDau.MaTranDau = Console.ReadLine();
            if (_check.CheckMaDoiBong(_lichThiDau.MaTranDau) == false)
            {
                Console.WriteLine("Không tìm thấy mã trận đấu");
            }
            else
            {
                Console.WriteLine("Ngày Thi Đấu:");
                _lichThiDau.NgayThiDau = Console.ReadLine();
                Console.WriteLine("Giờ Thi Đấu:");
                _lichThiDau.GioThiDau = Console.ReadLine();
                Console.WriteLine("Sân Thi Đấu:");
                _lichThiDau.SanThiDau = Console.ReadLine();
                if (_lichThiDauModel.SuaLichThiDau(_lichThiDau) != null)
                {
                    Console.WriteLine($"Sửa thành trận đấu");
                    Console.WriteLine($"Sẽ diễn ra vào lúc {_lichThiDau.NgayThiDau} {_lichThiDau.GioThiDau}");
                }
                else
                {
                    Console.WriteLine("Sửa không thành công vui lòng thử lại");
                }
            }
        }
    }
}