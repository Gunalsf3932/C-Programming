using System;
namespace Question3;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int terms=int.Parse(Console.ReadLine());
        
        for(int i=1;i<=terms;i++)
        {
            int cube=(i*i*i);
            System.Console.WriteLine($"Number is : {i} and cube of the {i} is: {cube}");
        }
    }
}