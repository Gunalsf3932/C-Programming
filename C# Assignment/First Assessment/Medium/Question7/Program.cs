using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the terms: ");
        int terms=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=5;i<=23;i++)
        {
            if(i%2!=0)
            {
                System.Console.Write(i+" ");
                sum+=i;
                
            }
        }
        System.Console.WriteLine("\n"+"Sum is " +sum);
        
        
    }
}