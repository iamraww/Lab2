using System;
using Lab2_T2009A_TRANANHDUC.controller;

namespace Lab2_T2009A_TRANANHDUC.view
{
    public class QuanLyKetQua
    {
        private KetQuaController _ketQuaController = new KetQuaController();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("========Quản lý lịch thi đấu========");
                Console.WriteLine("1. Xem kết quả");
                Console.WriteLine("2. Thêm kết quả thi đấu");
                Console.WriteLine("0. Quay lại menu");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _ketQuaController.XemKetQua();
                        break;
                    case 2:
                        _ketQuaController.ThemKetQua();
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