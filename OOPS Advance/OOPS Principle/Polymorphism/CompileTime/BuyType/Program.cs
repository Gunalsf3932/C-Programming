using System;
namespace BuyType;
class Program 
{

    static void Display(int number)
    {
        System.Console.WriteLine("Int Type : "+number);
    }

    static void Display(string name)
    {
        System.Console.WriteLine("String Type : "+name);
    }
    public static void Main(string[] args)
    {
        Display(100);
        Display("Program");
        
    }
}