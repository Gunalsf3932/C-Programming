using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string : ");
        string name=Console.ReadLine();

        System.Console.WriteLine("Enter the substring: ");
        string subname=Console.ReadLine();
        bool name1=(name.Contains(subname));
        if(name1==true)
        {
            System.Console.WriteLine("The substring exists in the substring");
        }
            
            
            
        
    }
}