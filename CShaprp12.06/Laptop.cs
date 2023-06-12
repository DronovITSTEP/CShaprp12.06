using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprp12._06
{
    internal class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }
    enum Vendors { Lenovo, HP, Acer};
    class Shop
    {
        private Laptop[] laptops;
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length) { return laptops[index]; }
                throw new IndexOutOfRangeException();
            }
            set { laptops[index] = value; }
        }
        public Laptop this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Vendors), name)) {
                    return laptops[(int)Enum.Parse(typeof(Vendors), name)];
                }
                else return new Laptop();
            }
            set
            {
                if (Enum.IsDefined(typeof(Vendors), name))
                {
                    laptops[(int)Enum.Parse(typeof(Vendors), name)] = value;
                }
            }
        }

        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price) return i;
            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                if (FindByPrice(price) >= 0)
                {
                    return this[FindByPrice(price)];
                }
                throw new Exception("Недопустимая стоимость");
            }
            set
            {
                if (FindByPrice(price) >= 0)
                    this[FindByPrice(price)] = value;
            }
        }
    }

    class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows; Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }

}
