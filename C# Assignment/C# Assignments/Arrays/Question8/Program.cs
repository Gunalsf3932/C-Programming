using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter limit : ");
        int n=int.Parse(Console.ReadLine());
        int[,] a=new int [n,n];
        int[,] b= new int[n,n];
        int[,] c=new int [n,n];
        System.Console.WriteLine("Enter 1 matrix :");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine($"Enter element a[{i}] [{j}]");
                a[i,j]=int.Parse(Console.ReadLine());
                
            }
        }
        System.Console.WriteLine("Second matrix : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine($"Element [{i}] [{j}]");
                b[i,j]=int.Parse(Console.ReadLine());
                
            }
        }

        System.Console.WriteLine("First matrix : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine(a[i,j]+" ");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("First matrix : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                System.Console.WriteLine(b[i,j]+" ");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("First matrix : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                c[i,j]=a[i,j]+b[i,j];
                System.Console.WriteLine(c[i,j]+" ");
            }
            System.Console.WriteLine();
        }  
    }
}