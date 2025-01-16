namespace LAB03
{
    internal class AdventureBook : Book

    {
        public string region;
        public AdventureBook(string title, Person author, DateTime publishDate, string region):base(title,author,publishDate)
        {
            this.region = region;
        }
    }
}