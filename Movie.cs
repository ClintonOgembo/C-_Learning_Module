using System.Dynamic;

class Movies
{
    public string title;
    public string director;
    private string rating;

    public Movies(string aTitle, string aDirector, string aRating)
    {
        title = aTitle;
        director = aDirector;
        Rating = aRating;
    }

    public string Rating
    {
        get { return rating; }
        set
        {
            if (value == "G" || value == "PG" || value == "R" || value == "PG-13")
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        }
    }
}