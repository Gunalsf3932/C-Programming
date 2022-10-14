using System;
namespace Question13;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter year : ");
        int year = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Month : ");
        int month = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Day : ");
        int date = int.Parse(Console.ReadLine());
        DateTime dateTime=new DateTime(year,month,date);
        System.Console.WriteLine(dateTime.ToShortDateString());
        System.Console.WriteLine(dateTime.DayOfWeek);
        
        
        
    }
}