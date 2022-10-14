using System;
namespace Qustion1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the inches:");
        int inches=int.Parse(Console.ReadLine());
        
        double number=inches*2.54;
        System.Console.WriteLine(number+"cm");
        
    }
}