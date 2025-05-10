using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
    class Book
    {
        public string BookName {  get; private set; }
        public string Author { get; private set; }

        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
        }

        public override string ToString()
        {
            return $"Книга \"{BookName}\", автор: {Author}";
        }

        public static void PrintBookInfo(Book book)
        {
            Console.WriteLine(book);
        }
    }
}
