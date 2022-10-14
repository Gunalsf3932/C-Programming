using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string name=Console.ReadLine();
        for(int i=0;i<name.Length;i++)
        {
            System.Console.Write(" "+name[i]);
        }
    }
}