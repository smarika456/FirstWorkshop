using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 7, 3, 9, 1, 5 };

        Array.Sort(numbers);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Array.Reverse(numbers);

        Console.WriteLine("Reversed array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int searchNumber = 5;
        int index = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine($"Index of {searchNumber}: {index}");
    }
}