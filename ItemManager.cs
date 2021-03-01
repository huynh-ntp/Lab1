using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class ItemManager
    {
        List<Item> ls = new List<Item>();

        public void Add()
        {
            Item i = new Item();
            i.InputCode();
            foreach (var j in ls)
            {
                if (j.code.Equals(i.code))
                {
                    Console.WriteLine("Item code existed !");
                    return;
                }
            }
            i.InputName();
            i.InputPrice();
            ls.Add(i);
            Console.WriteLine(i);
        }


        public void Update()
        {

            if (ls.Count == 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }
            Item i = new Item();
            i.InputCode();
           
            var l = from j in ls
                    where j.code.Equals(i.code)
                    select j;
            if (l.Count() == 0)
            {
                Console.WriteLine(" Not found!");
                return;
            }
            i.InputPrice();
            foreach (var j in l)
            {               
                j.price = i.price;
                break;
            }
            Console.WriteLine("Update successful");
        }


        public void Delete()
        {

            if (ls.Count == 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }

            Item temp = new Item();
            temp.InputCode();
            Item i = SearchByCode(temp.code);
            if (i != null)
            {
                ls.Remove(i);
                ShowAll();
            }
            else
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine("Delete successful");
        }

        public Item SearchByCode(String code)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if(ls[i].code == code)
                {
                    return ls[i];
                }
            }
            return null;
        }


        public void SearchByCode()
        {

            if (ls.Count == 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }

            Item temp = new Item();
            temp.InputCode();
            Item i = SearchByCode(temp.code);
            if (i != null)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        public void ShowAll()
        {
            foreach (Item i in ls)
            {
                Console.WriteLine(i);
            }
        }
        public void ShowOrderByPrice()
        {
            if (ls.Count == 0)
            {
                Console.WriteLine("Empty list!");
                return;
            }

            ls.Sort();
            ShowAll();
        }
        

    }
}
