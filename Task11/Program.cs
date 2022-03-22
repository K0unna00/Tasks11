using System;

namespace Task11
{
    internal class Program
    {
        static Notebook[] getFilteredPrice(Notebook[] array , double minprice , double maxprice)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    count++;
                }
            }
            Notebook[] result = new Notebook[count];
            int count2 = 0;
            foreach (var item in array)
            {
                if (item.price > minprice && item.price < maxprice)
                {
                    result[count2++] = item;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kitablarin sayi :");
            int count1 = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.books = new Book[count1];

            for (int i = 0; i < count1; i++)
            {
                string name = "", genre = "";
                int count = 0, no = 0;
                double price = 0;
                bool check = true;
                while (name.Length < 1 || name.Length > 50)
                {
                    Console.WriteLine("Kitabin adini yazin : ");
                    name = Console.ReadLine();
                }
                while (genre.Length < 3 || genre.Length > 20)
                {
                    Console.WriteLine("Kitabin janri :");
                    genre = Console.ReadLine();
                }
                while (price <= 0)
                {
                    Console.WriteLine("Kitabin qiymeti : ");
                    price = double.Parse(Console.ReadLine());
                }
                while (count <= 0)
                {
                    Console.WriteLine("Kitabin sayi : ");
                    count = int.Parse(Console.ReadLine());
                }
                while (check)
                {
                    check = false;
                    Console.WriteLine("Kitabin nomresi : ");
                    no = int.Parse(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (library.books[j].no == no)
                        {
                            check = true;
                            break;
                        }
                    }
                }
                Book book = new Book(genre, no, price, name, count);
                library.AddBook(book);
            }
            bool check1 = true;
            while (check1)
            {
                Console.WriteLine("Filter Olunsun ? :  y / n ");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                {
                    while (true)
                    {
                        Console.WriteLine(" 1- Janra gore , 2- Qiymet intervalina gore   1 / 2 ");
                        answer = char.Parse(Console.ReadLine());
                        if (answer == '1')
                        {
                            Console.WriteLine("Hansi janr filterlensin");
                            string genre = Console.ReadLine();
                            library.getInfo(library.GetFilteredBooksGenre(genre));
                            check1 = false;
                            break;
                        }
                        else if (answer == '2')
                        {
                            Console.WriteLine("Hansi Qiymet intervalinda axtarsin ?  min | max");
                            double minprice = double.Parse(Console.ReadLine());
                            double maxprice = double.Parse(Console.ReadLine());
                            library.getInfo(library.GelFilteredBooksPrice(minprice, maxprice));
                            check1 = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanliz 1 ve ya 2 qiymetleri daxil edile biler");
                        }

                    }
                }
                else if (answer == 'n')
                {
                    library.getInfo(library.books);
                    check1 = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanliz y ve ya n deyerleri velire biler");
                }
            }
        }
    }
}
