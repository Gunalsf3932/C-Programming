using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Date : ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime yesterday=date.AddDays(-1);
        DateTime tommorow=date.AddDays(1);
        System.Console.WriteLine($"Yesterday : {yesterday.ToShortDateString()} \n Tommorow: {tommorow.ToShortDateString()}");
        
    }
}