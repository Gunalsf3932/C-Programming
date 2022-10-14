using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the X value: ");
        int xValue=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the Y value: ");
        int yValue=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=yValue;i++)
        {
            sum=xValue*xValue;
        }
        
        System.Console.WriteLine($"{xValue} and {yValue} is {sum}");
    }
}