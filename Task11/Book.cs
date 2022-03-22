using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    internal class Book : Product
    {
        public Book(string genre, int no, double price, string name) : base(no, price, name)
        {
            this.genre = genre;
        }
        public Book(string genre, int no, double price, string name, int count) : base(no, price, name, count)
        {
            this.genre = genre;
        }
        public string genre;

    }
}
