using System;
namespace Question11;
class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Data");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine($"The Date of the day : {date.ToShortDateString()}");
        for(int i=0;i<12;i++)
        {
            DateTime month = date.AddMonths(i);
            System.Console.WriteLine(month.ToString("MMMM"));
        }
        
    }
}