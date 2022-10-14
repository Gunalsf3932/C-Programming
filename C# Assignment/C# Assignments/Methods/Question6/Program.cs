using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number : ");
        int value=int.Parse(Console.ReadLine());
        Fibonacci(value);

        void Fibonacci(int value)
        {
        
            int f=1;
            for (int i=1;i<=value;i++)
            {
                f=f*i;
            }
            System.Console.WriteLine($"The factorial of {value}! is : {f}");
        }
    }
}