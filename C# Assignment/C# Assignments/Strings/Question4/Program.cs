using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        int Count=0;
        System.Console.WriteLine("Enter the string name:");
        string name= Console.ReadLine();
        
        
        
        string[] split1=name.Split(' ');
        int len=split1.Length;
        for(int i=0;i<len;i++)
        {
            Count++;
        }
        System.Console.WriteLine($"Total number of words in the string : {Count}");

        
        
    }
}