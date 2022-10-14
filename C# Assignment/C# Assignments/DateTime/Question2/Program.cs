using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter DateTime input:");
        DateTime dateTime=new DateTime(2022,04,28,11,49,05);
        System.Console.WriteLine("Complete Date : "+dateTime.ToString("dd/MM/yyyy HH/mm/ss tt"));
        System.Console.WriteLine("Short Date: "+dateTime.ToShortDateString());
        System.Console.WriteLine("Long Date : "+dateTime.ToShortDateString());
        System.Console.WriteLine("12 hours : "+dateTime.ToString("dd/MM/yyyy hh/mm/ss tt"));
        System.Console.WriteLine("Date Only : "+dateTime.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("Time Only : "+dateTime.ToString("HH/mm/ss tt"));
    }
}