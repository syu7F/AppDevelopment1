using System;

public enum Genre
{
    Action = 1,
    Comedy = 2,
    Drama = 3,
    Horror = 4,
    SciFi = 5
}

public class Movie
{
    public int Id;
    public string Name;
    public int Year;
    public Genre Genre;
    public int Views;
    public int Likes;

    public void ReadFromLine(string line)
    {
        string[] parts = line.Split(',');

        Id = int.Parse(parts[0].Trim());
        Name = parts[1].Trim();
        Year = int.Parse(parts[2].Trim());
        Genre = GetGenre(int.Parse(parts[3].Trim()));
        Views = int.Parse(parts[4].Trim());
        Likes = int.Parse(parts[5].Trim());
    }

    public Genre GetGenre(int number)
    {
        switch (number)
        {
            case 1: return Genre.Action;
            case 2: return Genre.Comedy;
            case 3: return Genre.Drama;
            case 4: return Genre.Horror;
            case 5: return Genre.SciFi;
            default: return Genre.Action;
        }
    }

    public double GetRating()
    {
        if (Views == 0)
            return 0;

        return Math.Sqrt((double)Likes * Likes / Views);
    }

    public override string ToString()
    {
        return string.Format("{0,4} {1,-15} {2,-8} {3,-12} {4,8:F3}",
            Id,
            Name,
            "(" + Year + ")",
            Genre,
            GetRating());
    }
}