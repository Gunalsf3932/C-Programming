using System;
namespace Question12;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter month : ");
        DateTime month = DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter month : ");
        DateTime year = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine($"The number of days {month.ToString("MMMM")} is {DateTime.DaysInMonth(year.Year,month.Month)}");
        
        
    }
}