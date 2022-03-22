using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    internal class Library
    {


        public Book[] books;

        int j = 0;
        public void AddBook(Book book)
        {
            books[j++] = book;
        }
        public Book[] GetFilteredBooksGenre(string genre)
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.genre == genre)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int count2 = 0;
            foreach (var item in books)
            {
                if (item.genre == genre)
                {
                    newbooks[count2++] = item;
                }
            }
            return newbooks;
        }
        public Book[] GelFilteredBooksPrice(double minprice, double maxprice)
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int count2 = 0;
            foreach (var item in books)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    newbooks[count2++] = item;
                }
            }
            return newbooks;
        }
        public void getInfo(Book[] books)
        {
            foreach (var item in books)
            {
                Console.WriteLine($"Name : {item.name} Price {item.price} Genre : {item.genre} No : {item.no} Count : {item.count} ");
            }
        }

    }
}
