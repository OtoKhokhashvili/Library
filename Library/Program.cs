using Library.DataManagment;
using Library.Models;
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book() { Id = 0, Author = "1", Name = "1", YearOfPublication = "1" };
            Book Book2 = new Book() { Id = 0, Author = "2", Name = "2", YearOfPublication = "2" };
            Book Book3 = new Book() { Id = 0, Author = "3", Name = "3", YearOfPublication = "3" };
            Book Book4 = new Book() { Id = 0, Author = "4", Name = "4", YearOfPublication = "4" };
            Book Book5 = new Book() { Id = 0, Author = "5", Name = "5", YearOfPublication = "5" };
            BookManager x = new BookManager();
            x.Add(Book1);
            x.Add(Book2);
            x.Add(Book3);
            x.Add(Book4);
            x.Delete(4);
            x.Add(Book5);
            foreach (var item in x._bookList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
