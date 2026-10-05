using System;

class Program
{
    static void Main()
    {
        byte a = 20;
        short b = 300;
        int c = 1000;
        long d = 900000L;
        float e = 36.5f;
        double f = 99.99;
        decimal g = 25000.50m;
        char h = 'A';
        bool i = true;

        string numberText = 42.ToString();
        double convertedNumber = Convert.ToDouble("3.14");

        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"float: {e}");
        Console.WriteLine($"double: {f}");
        Console.WriteLine($"decimal: {g}");
        Console.WriteLine($"char: {h}");
        Console.WriteLine($"bool: {i}");

        Console.WriteLine($"Integer to string: {numberText}");
        Console.WriteLine($"String to double: {convertedNumber}");
    }
}