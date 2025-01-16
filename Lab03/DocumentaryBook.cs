namespace LAB03
{
    internal class DocumentaryBook : Book
    {
        public string topic;
        public DocumentaryBook(string title, Person author, DateTime publishDate, string topic) : base(title, author, publishDate)
        {
            this.topic = topic;
        }
    }
}