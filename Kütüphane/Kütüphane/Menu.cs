using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class Menu
    {
        public static void MenuBook()
        {
            List<Book> books = new List<Book>();
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seçenek");
            Console.WriteLine("1-Kitap Ekle");
            Console.WriteLine("2-Kitap Sil");
            Console.WriteLine("3-Eklenen Kitaplar");
            Console.WriteLine("Q Çıkış ");
            ConsoleKeyInfo basilan;
            basilan = Console.ReadKey();
            int ID = 0;
            while (basilan.Key!=ConsoleKey.Q)
            {
               
                if (basilan.Key==ConsoleKey.D1)
                {
                    Book book = new Book();
                    ID++;
                    book = kitapIslemleri.AddBook(ID);
                    if (book.name != "" && book.Author != "")
                    {
                        books.Add(book);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Başarı ile eklendi.");
                    }
                    else
                    {
                        ID--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eksik bilgiler var!.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("---------------------------------");
                }else
                  if (basilan.Key == ConsoleKey.D2)
                   {
                    Console.Clear();
                    Console.Write("Kitap Ismi:");
                    Book book = books.Where(x => x.name == Console.ReadLine()).FirstOrDefault();
                    books.Remove(book);
                    Console.Clear();
                    if(book!=null)
                    Console.WriteLine("Başarı ile silindi.");
                    else
                    Console.WriteLine("Bulunamadı.");

                }
                else
                  if (basilan.Key == ConsoleKey.D3)
                {
                    kitapIslemleri.Books(books);
                }
                Console.WriteLine("Seçenek");
                Console.WriteLine("1-Kitap Ekle");
                Console.WriteLine("2-Kitap Sil");
                Console.WriteLine("3-Eklenen Kitaplar");
                Console.WriteLine("Q Çıkış ");
                basilan = Console.ReadKey();
            }
        }
    }
}
