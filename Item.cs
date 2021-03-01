using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab1
{
    class Item : IComparable<Item>
    {
        private string _code;
        private string _name;
        private float _price;

        public Item(String code, String name, float price)
        {
            _code = code;
            _name = name;
            _price = price;
        }

        

        public Item() {         
        }

        public string code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int CompareTo( Item other)
        {
            return this._price.CompareTo(other._price);
        }

        public void InputCode()
        {
            while (true)
            {
                Console.Write("Enter code:");
                _code = Console.ReadLine().Trim();
                if (_code.Length == 0)
                {
                    Console.WriteLine("Code not empty!");
                }
                else
                {
                    break;
                }
            }
        }

        public void InputName()
        {
            while (true)
            {
                Console.Write("Enter name:");
                _name = Console.ReadLine().Trim();
                if (_name.Length == 0)
                {
                    Console.WriteLine("Name not empty!");
                }
                else
                {
                    break;
                }
            }
        }

        public void InputPrice()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter price: ");
                    _price = float.Parse(Console.ReadLine());
                    if (price <= 0)
                    {
                        Console.WriteLine("Price must be bigger than 0");
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid price! Please enter again!");
                }
            }
        }

        public override string ToString()
        {
            string str = string.Format("Code: {0}, Name: {1}, Price: {2}", _code, _name, _price);
            return str;
        }

        public void Input()
        {
            InputCode();
            InputName();
            InputPrice();
        }

        
    }

}
