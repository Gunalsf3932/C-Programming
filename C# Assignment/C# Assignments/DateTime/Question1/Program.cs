using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ENter DateTime:");
        DateTime[] dateTime={DateTime.Now,new DateTime(2016,08,16,09,28,00),new DateTime(2011,05,28,10,35,0),new DateTime(1979,12,25,14,30,00)};
        for(int i=0;i<dateTime.Length;i++)
        {
            System.Console.WriteLine($"Day : {dateTime[i].ToString("dd/MM/yyyy HH:mm:ss tt")}\n Day:{dateTime[i].ToString("dd/MM/yyyy hh:mm:ss tt")}");
        }
    }
}