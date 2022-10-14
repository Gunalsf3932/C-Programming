using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int f=1;
        for(int i=1;i<=number;i++)
        {
            f=f*i+(i*i*i);
            
        }
        System.Console.WriteLine(f);
        
    }
}