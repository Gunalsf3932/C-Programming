using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter year");
        DateTime dateTime=new DateTime();
        dateTime=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        for(int i=0;i<=10;i++)
        {
            DateTime datadisplay=dateTime.AddYears(i);
            System.Console.WriteLine($"{datadisplay.ToString("dd/MM/yyyy")}: day {datadisplay.DayOfYear} of {datadisplay.Year}");
        }
    }
}