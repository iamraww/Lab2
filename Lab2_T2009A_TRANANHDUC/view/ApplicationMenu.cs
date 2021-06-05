using System;
using Lab2_T2009A_TRANANHDUC.controller;

// ReSharper disable FunctionNeverReturns

namespace Lab2_T2009A_TRANANHDUC.view
{
    public class ApplicationMenu
    {
        private DoiBongMenu _doiBongMenu = new DoiBongMenu();
        private LichThiDauMenu _lichThiDauMenu = new LichThiDauMenu();
        private QuanLyKetQua _quanLyKetQua = new QuanLyKetQua();
        private KetQuaController _ketQuaController = new KetQuaController();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("-----Chào mừng đến với V-League 2008-----");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Quản lý danh sách đội bóng.");
                Console.WriteLine("2. Quản lý lịch thi đấu.");
                Console.WriteLine("3. Quản lý kết quả thi đấu.");
                Console.WriteLine("4. Thống kê.");
                Console.WriteLine("0. Thoát.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _doiBongMenu.Menu();
                        break;
                    case 2:
                        _lichThiDauMenu.Menu();
                        break;
                    case 3:
                        _quanLyKetQua.Menu();
                        break;
                    case 4:
                        Console.WriteLine("Thống Kê");
                        break;
                    default:
                        break;
                }

                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}