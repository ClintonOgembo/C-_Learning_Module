class Book
{
    public string title;
    public string author;
    public int pages;

    public Book(string aTitle, string aAuthor, int aPages)
    {
        title = aTitle;
        author = aAuthor;
        pages = aPages;
    }

    public bool HasHonors()
    {
        if (pages >= 400)
        {
            return true;
        }
        return false;
    }
}