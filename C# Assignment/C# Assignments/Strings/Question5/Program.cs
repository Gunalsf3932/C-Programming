using System;
namespace Question5;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string 1:");
        string name1=Console.ReadLine();
        
        System.Console.WriteLine("Enter the string 2:");
        string name2=Console.ReadLine();
        
        if (name1==name2)
        {
            System.Console.WriteLine("The length of both strings are equal and so, both strings are equal");

        }        
    }
}