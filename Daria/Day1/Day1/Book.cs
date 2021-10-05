namespace Day1
{
    public class Book
    {
        public string author;
        public string Title { get; set; }
        public int yearOfPublication;
        public string[] jenre;
        public string type;
        public Book(string Author,string title)
        {
            author = Author;
            Title = title;
        }
        public Book()
        {
            author = "0";
        }
        public void  SetTitle(string a)
        {
            Title = a;
        }
    }
}
