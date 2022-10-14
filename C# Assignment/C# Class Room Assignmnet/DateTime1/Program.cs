using System;
namespace DateTime1;
class Program 
{
    public static void Main(string[] args)
    {
      
        DateTime dob1 = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year: "+dob1.Year);
        System.Console.WriteLine("Month: "+dob1.Month);
        System.Console.WriteLine("Day: "+dob1.Day);
        System.Console.WriteLine("Hour: "+dob1.Hour);
        System.Console.WriteLine("Minute: "+dob1.Minute);
        System.Console.WriteLine("Second: "+dob1.Second);

        
        string[] splitChar=dob1.split(new char[] {','});
        


    


    }
}