using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public Book()
        {
        }

        public Book(string title, string author, string publisher,DateTime releaseDate,string isbn,decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int bookCount = int.Parse(Console.ReadLine());
            Library library = new Library("");
            while (bookCount-->0)
            {
                string[] bookInfo = Console.ReadLine().Split(' ');

                Library books = new Library();
                string title = bookInfo[0];
                string author = bookInfo[1];
                string publisher = bookInfo[2];
                DateTime releaseDate = DateTime.ParseExact(bookInfo[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                string isbn = bookInfo[4];
                decimal price = decimal.Parse(bookInfo[5]);

                Book book = new Book(title,author,publisher,releaseDate,isbn,price);
                library.AddBook(book);
            }

            Dictionary<string, decimal> authorPrice = new Dictionary<string, decimal>();
            foreach (var book in library.Books)
            {
                if (!authorPrice.Contains(book.Author))
                {
                    authorPrice.Add(book.Author, book.Price);
                }
                else
                {
                    authorPrice[book.Author] += book.Price;
                }
            }

            foreach (var book in authorPrice.OrderByDescending(b=>b.Value).ThenBy(b=>b.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value}");
            }
        }
        //
        DateTime checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        library.books.Where(d=>d.ReleaseDate>checkDate).OrderBy(d=>ReleaseDate).ThenBy(t=>t.Title).ToList().foreach(Console.WriteLine($"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}"))
    }
}
