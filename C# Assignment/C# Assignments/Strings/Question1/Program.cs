using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String Name: ");
        string name=Console.ReadLine();

         int output=name.Length;
         System.Console.WriteLine("Length of the string is : "+output);
    }
}