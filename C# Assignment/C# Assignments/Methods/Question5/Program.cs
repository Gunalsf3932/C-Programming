using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int value=int.Parse(Console.ReadLine());
        Fibonacci(value);

        void Fibonacci(int value)
        {
        
            int f=0;
            for(int i=1;i<=value;i++)
            {
                if(value%i==0)
                {
                    f++;
                }
             
             
            }
                if(f==2)
             {
                System.Console.WriteLine(value+" is a prime number");
             }    
             else{
                System.Console.WriteLine(value+" is not a prime number");
             }
             
            
        }
        }
    }
