using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the user Id: ");
        string id=Console.ReadLine();
        
        System.Console.WriteLine("Enter the user Pass: ");
        string pass=Console.ReadLine();
        
        if(id=="user" && pass=="pass")
        {
            System.Console.WriteLine("Password Entered Successfully");
        }
    }
}