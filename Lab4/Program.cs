using System;

class Program
{
    static void A(in int x)
    {
        Console.WriteLine("in: " + x);
    }

    static void B(out int result)
    {
        result = 100;
        Console.WriteLine("out: " + result);
    }

    static void C(ref int number)
    {
        number += 5;
        Console.WriteLine("ref: " + number);
    }

    static int SumValues(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
            sum += number;
        return sum;
    }

    static void Main()
    {
        int a = 7;
        A(in a);

        int b;
        B(out b);

        int c = 20;
        C(ref c);
        Console.WriteLine("Main c: " + c);

        Console.WriteLine("Sum: " + SumValues(1, 2, 3));
        Console.WriteLine("Sum: " + SumValues(10, 20, 30, 40, 50));
        Console.WriteLine("Sum: " + SumValues());
    }
}