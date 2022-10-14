using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int value=int.Parse(Console.ReadLine());
        Fibonacci(value);

        void Fibonacci(int value)
        {
        
        
        int i=0;
        int a=-1;
        int b=1;
        int c;
        System.Console.WriteLine("The Fibonacci series of 5 numbers is :");
        while(i<=value-1)
        {
            c=a+b;
            
            System.Console.WriteLine(c);
            a=b;
            b=c;
            i++;
        }
        }
    }
}