using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter limit :");
        int n=int.Parse(Console.ReadLine());
        int[,] a=new int[n,n];
        System.Console.WriteLine("Enter elements : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine($"Enter element a[{i}] [{j}]");
                a[i,j]=int.Parse(Console.ReadLine());
                
            }
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine($"{a[i,j]}");
            }
            System.Console.WriteLine();
        }
        
    }
}