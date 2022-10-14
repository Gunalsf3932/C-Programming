using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input dd/MM/yyyy Days of Week");
        DateTime input=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine($"The Day of the week for {input.ToString("dd/MM/yyyy")} is {input.DayOfWeek}");
    }
}