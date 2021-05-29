using System;
using Lab2_T2009A_TRANANHDUC.entity;
using Lab2_T2009A_TRANANHDUC.model;

namespace Lab2_T2009A_TRANANHDUC.controller
{
    public class DoiBongController
    {
        private DoiBong _doiBong = new DoiBong();
        private DoiBongModel _doiBongModel = new DoiBongModel();
        private Check _check = new Check();
        
        public void ThemDoiBong()
        {
            Console.WriteLine("======Thêm mới một đội bóng=======");
            Console.WriteLine("Nhập Mã đội: ");
            _doiBong.MaDoiBong = Console.ReadLine();
            Console.WriteLine("Nhập tên đôi: ");
            _doiBong.TenDoiBong = Console.ReadLine();
            Console.WriteLine("Nhập tên HLV: ");
            _doiBong.HuanLuyenVien = Console.ReadLine();
            if (_doiBongModel.ThemDoiBong(_doiBong) != null)
            {
                Console.WriteLine($"Thêm thành công đội bóng {_doiBong.TenDoiBong}");
            }
        }

        public void SuaDoiBong()
        {
            Console.WriteLine("======Cập nhật thông tin đội bóng======");
            Console.WriteLine("Nhập Mã đội bóng cần sửa");
            _doiBong.MaDoiBong = Console.ReadLine();
            if (_check.CheckMaDoiBong(_doiBong.MaDoiBong) == false)
            {
                Console.WriteLine("Không tìm thấy mã đội bóng");
            }
            else
            {
                Console.WriteLine("Nhập Tên Đội Mới: ");
                _doiBong.TenDoiBong = Console.ReadLine();
                Console.WriteLine("Nhập Huấn Luyện Viên Mới: ");
                _doiBong.HuanLuyenVien = Console.ReadLine();
                if (_doiBongModel.SuaDoiBong(_doiBong) != null)
                {
                    Console.WriteLine($"Sửa thành công đội bóng {_doiBong.MaDoiBong}");
                }
            }
        }

        public void XemDoiBong()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(
                $"|{"Mã đội bóng",20}{"",10}|{"Tên đội bóng",20}{"",10}|{"Huấn Luyện viên",20}{"",10}|");
            _doiBongModel.XemThongTin();
            
            // while (_doiBongModel.XemThongTin() != null)
            // {
            //     DoiBong _db = _doiBongModel.XemThongTin();
            //     Console.WriteLine(
            //         $"|{_doiBong.MaDoiBong,20}{"",10}|{_doiBong.TenDoiBong,20}{"",10}|{_doiBong.HuanLuyenVien,20}{"",10}|");
            //
            // }
        }
    }
}