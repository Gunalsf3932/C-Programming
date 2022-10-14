using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter starting number: ");
        int start=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter ending number: ");
        int ending=start+int.Parse(Console.ReadLine());
        for (int i=start;i<ending;i++)
        {
            System.Console.Write(name[i]);
        }
        
        
    }
} 

