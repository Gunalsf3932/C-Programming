using System;
namespace Question6;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Price amount: ");
        int price=int.Parse(Console.ReadLine());
        
        double tax=0.18;
        double total=price +(int)price *tax;
        System.Console.WriteLine($"Total = {total}");

        
    }
}
