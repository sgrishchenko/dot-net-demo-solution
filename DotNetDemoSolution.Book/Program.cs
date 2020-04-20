using System;

namespace DotNetDemoSolution.Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Герберт Шилдт", "Полный справочник пo C# 4.0", 2010);
            Book book2 = new Book();
            Book book3;
            
            Console.WriteLine(book1.Author + ", " + book1.Title + ", (c) " + book1.Copyright);
            Console.WriteLine();
            if (book2.Title == null)
                Console.WriteLine("Member book2.Title is empty.");

            book2.Title = "О дивный новый мир";
            book2.Author = "Олдос Хаксли";
            book2.Copyright = 1932;
            
            Console.WriteLine("book2 contains now:");
            Console.WriteLine(book2.Author + ", " + book2.Title + ", (c) " + book2.Copyright);
            Console.WriteLine();

            book3.Title = "Красный шторм";
            Console.WriteLine(book3.Title);
        }
    }
}
