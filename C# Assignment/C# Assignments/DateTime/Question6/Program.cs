using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a data Time");
        DateTime today=DateTime.Now;
        DateTime after40=today.AddDays(40);
        System.Console.WriteLine($"Today = {today.ToString()}\n After 40 days : {after40.DayOfWeek}");
    }
}