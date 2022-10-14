using System;
namespace Question4;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the table:");
        int table=int.Parse(Console.ReadLine());

        for(int i=1;i<=10;i++)
        {
            System.Console.WriteLine($"{table} x {i}={table*i}");
        }
    }
}