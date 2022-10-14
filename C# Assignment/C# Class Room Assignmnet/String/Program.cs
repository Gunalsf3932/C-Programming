using System;
namespace Question;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string name:");
        string name=Console.ReadLine();
      
        System.Console.WriteLine("Enter the substring name:");
        string substring=Console.ReadLine();

        string[] splitstring=name.Split(substring, StringSplitOptions.None);
        int count=0;
        foreach( string i in splitstring)
        {
            
            count++;
        }
        System.Console.WriteLine($"{count-1}");

        }
  
    }
