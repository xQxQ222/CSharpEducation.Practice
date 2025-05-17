namespace Practice3.Task4
{
    class Book
    {
        public string BookName { get; private set; }
        public string Author { get; private set; }

        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
        }

        public Book() : this("Самый богатый человек Вавилона", "Иванов И. И.") { }

        public override string ToString()
        {
            return $"Книга \"{BookName}\". Автор: {Author}";
        }
    }
}
