
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Mango"
        };

        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruit List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary =
            new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Mango" }
            };

        fruitDictionary.Add(4, "Orange");

        Console.WriteLine("Fruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}
