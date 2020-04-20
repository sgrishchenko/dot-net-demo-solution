namespace DotNetDemoSolution.Book
{
    struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;

        public Book(string author, string title, int copyright)
        {
            Author = author;
            Title = title;
            Copyright = copyright;
        }
    }
}