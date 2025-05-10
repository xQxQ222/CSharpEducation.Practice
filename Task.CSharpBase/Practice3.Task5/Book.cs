using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    class Book
    {
        public string BookName { get; private set; }
        public string Author { get; private set; }
        public int PublishingYear { get; private set; }

        public Book(string bookName, string author, int publishingYear)
        {
            BookName = bookName;
            Author = author;
            PublishingYear = publishingYear;
        }


        public Book(string bookName, string author): this(bookName, author, 2000) { }

        public Book(string bookName) : this(bookName, "Иванов И. И.", 2000) { }


        public Book() : this("Самый богатый человек Вавилона", "Иванов И. И.", 2000) { }

        public override string ToString()
        {
            return $"Книга \"{BookName}\". Автор: {Author}. Год издания: {PublishingYear}";
        }
    }
}
