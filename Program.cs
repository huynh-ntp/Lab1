using System;

namespace Lab1
{   

    



    class Program
    {
        static void Main(string[] args)
        {           
            ItemManager im = new ItemManager();
            Menu menu = new Menu();
            bool flag = true;
            while (flag)
            {
                menu.ShowMenu();              
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                    {
                        case "1":                            
                            im.Add();
                            break;
                        case "2":                         
                            im.Update();
                            break;
                        case "3":                           
                            im.Delete();
                            break;
                        case "4":                           
                            im.SearchByCode();
                            break;
                        case "5":
                            im.ShowOrderByPrice();
                            break;
                        case "6": flag = false;
                        Console.WriteLine("Good bye!");
                            break;
                     default:
                        Console.WriteLine("Please choice from 1 to 6!");
                        break;                         
                }
            }
        }
    }
}
