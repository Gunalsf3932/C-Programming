using System;
namespace Question9;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed: ");
        int speed=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the time: ");
        int time=int.Parse(Console.ReadLine());
        
        double output=(double)(speed*time)*(double)(0.2777);
    
        int result=(int)output;
        System.Console.WriteLine($"Output = {result}");
    }
}