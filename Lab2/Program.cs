using System;

class Program
{
    static int ToMultiplicate(int x, int n = 2)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += x;
        return sum;
    }

    static double ToMultiplicate(double x, int n = 2)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
            sum += x;
        return sum;
    }

    static string ToMultiplicate(string x, int n = 2)
    {
        string result = "";
        for (int i = 0; i < n; i++)
            result += x;
        return result;
    }

    static void Main()
    {

        Console.WriteLine(ToMultiplicate(5));      
        Console.WriteLine(ToMultiplicate(5, 4));     

        Console.WriteLine(ToMultiplicate(2.5));     
        Console.WriteLine(ToMultiplicate(2.5, 3));   

        Console.WriteLine(ToMultiplicate("ab"));     
        Console.WriteLine(ToMultiplicate("ab", 3));  
    }
}