using System;
using Lab2_T2009A_TRANANHDUC.controller;

namespace Lab2_T2009A_TRANANHDUC.view
{
    public class LichThiDauMenu
    {
        private LichThiDauController _lichThiDauController = new LichThiDauController();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("==========Quản lý lịch thi đấu============");
                Console.WriteLine("1. Xem lịch thi đấu");
                Console.WriteLine("2. Cập nhật cập nhật lịch thi đấu");
                Console.WriteLine("3. Tạo lịch thi đấu");
                Console.WriteLine("0. Trờ về menu chính.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _lichThiDauController.XemLichThiDau();
                        break;
                    case 2:
                        _lichThiDauController.SuaLichThiDau();
                        break;
                    case 3:
                        _lichThiDauController.TaoLichThiDau();
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