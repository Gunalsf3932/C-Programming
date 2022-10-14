using System;

namespace Question1;

class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Test Data: ");
        int testData=Convert.ToInt32(Console.ReadLine());

        if(testData%2==0)
        {
            System.Console.WriteLine($"{testData} is an even integer");
        }
        else
        {
            System.Console.WriteLine($"{testData} is an odd integer");
        }
    }
}