using System;
namespace Question3;
class Prgram 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input order dd/MM/yyyy hh:mm:ss tt : ");
        DateTime input=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine("Year : "+input.Year);
        System.Console.WriteLine("Month : "+input.Month);
        System.Console.WriteLine("Date : "+input.Date);
        System.Console.WriteLine("Hour : "+input.Hour);
        System.Console.WriteLine("Minute : "+input.Minute);
        System.Console.WriteLine("Second : "+input.Second);
        System.Console.WriteLine("MilliSecond : "+input.Millisecond);
        
         
    }
}