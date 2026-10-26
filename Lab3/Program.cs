using System;

class Program
{
    static void Main()
    {
        Console.Write("Movies count: ");
        int count = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[count];

        Console.WriteLine("Format: Id, Name, Year, Genre(1-5), Views, Likes");
        for (int i = 0; i < count; i++)
        {
            Console.Write("Movie " + (i + 1) + ": ");
            movies[i] = new Movie();
            movies[i].ReadFromLine(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < count; i++)
            Console.WriteLine(movies[i]);
    }
}