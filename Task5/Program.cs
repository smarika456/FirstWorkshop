using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2006, 5, 15);
        DateTime currentDateTime = DateTime.Now;

        TimeSpan ageSpan = currentDateTime - birthDate;
        int age = (int)(ageSpan.TotalDays / 365.2425);

        Console.WriteLine($"Birthdate: {birthDate:dd/MM/yyyy}");
        Console.WriteLine($"Current date and time: {currentDateTime}");
        Console.WriteLine($"Age: {age} years");

        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"After 10 days: {newDate:dd/MM/yyyy}");
    }
}