using System;
using Lab2_T2009A_TRANANHDUC.controller;

namespace Lab2_T2009A_TRANANHDUC.view
{
    public class DoiBongMenu
    {
        private DoiBongController _doiBongController = new DoiBongController();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("1. Xem danh sách đội bóng");
                Console.WriteLine("2. Cập nhật danh sách đội bóng");
                Console.WriteLine("3. Thêm mới một đội bóng");
                Console.WriteLine("0. Trờ về menu chính.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _doiBongController.XemDoiBong();
                        break;
                    case 2:
                        _doiBongController.SuaDoiBong();
                        break;
                    case 3:
                        _doiBongController.ThemDoiBong();
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