using System;
namespace Question14;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Month : ");
        DateTime month=DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter leaves : ");
        int leave =int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter 1 day salary :");
        int salaryday1=int.Parse(Console.ReadLine());

        int dateTime=DateTime.DaysInMonth(0001,month.Month)-leave;
        System.Console.WriteLine($"Salary : {dateTime*salaryday1}");
        
        
        
    }
}