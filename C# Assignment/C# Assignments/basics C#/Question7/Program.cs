using System;
namespace Question7;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input a: ");
        int a=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the input b: ");
        int b=int.Parse(Console.ReadLine());

        int output= (a*a)+(2*a*b)+(b*b);
        System.Console.WriteLine($"Output = {output}");
    }
}