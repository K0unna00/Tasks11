using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    internal class Product
    {

        public Product(int no, double price, string name)
        {
            this.no = no;
            this.price = price;
            this.name = name;
        }
        public Product(int no, double price, string name, int count) : this(no, price, name)
        {
            this.count = count;
        }

        public int no;
        public int count;
        public string name;
        public double price;
    }
}
