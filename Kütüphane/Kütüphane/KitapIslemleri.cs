using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class KitapIslemleri
    {
        public Book AddBook(int ID)
        {
            Console.Clear();
            Book book = new Book();
            Console.Write("Kitap Adi:");
            book.name = Console.ReadLine();
            Console.Write("Yazar Ismi:");
            book.Author = Console.ReadLine();
            book.ID = ID;
            Console.Clear();
            return book;
        }
        public void Books(List<Book> books)
        {
            Console.Clear();
            Console.WriteLine("ID KITAP YAZAR");
            foreach (Book book in books)
            {
                Console.WriteLine("{0} {1} {2}",book.ID,book.name,book.Author);  
            }
            Console.WriteLine("Menuye donmek icin bir tusa bas...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
