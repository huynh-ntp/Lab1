using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("----------- The management program of Item ----------");
            Console.WriteLine();
            Console.WriteLine("1. Add new item");
            Console.WriteLine("2. Update price item");
            Console.WriteLine("3. Delete item");
            Console.WriteLine("4. Search item by code");
            Console.WriteLine("5. Display item in order of price");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.WriteLine("Input a number between 1 and 6 ");
        }
    }
}
