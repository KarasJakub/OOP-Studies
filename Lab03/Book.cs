namespace LAB03
{
    internal class Book
    {
        protected string title;
        protected Person author;
        protected DateTime publishDate;

        public Book(string title, Person author, DateTime publishDate)
        {
            this.title = title;
            this.author = author;
            this.publishDate = publishDate;
        }

        public void View()
        {
            Console.WriteLine($"Tytuł: {title}, Autor:");
            author.View();
            Console.WriteLine($"Data wydania: {publishDate}");
        }
    }
}