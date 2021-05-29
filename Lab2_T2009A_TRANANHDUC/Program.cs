using System;
using System.Text;
using Lab2_T2009A_TRANANHDUC.view;

namespace Lab2_T2009A_TRANANHDUC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ApplicationMenu menu = new ApplicationMenu();
            menu.Menu();
        }
    }
}