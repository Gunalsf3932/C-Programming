using System;
namespace Question;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the test data: ");
        int data=int.Parse(Console.ReadLine());
        
        if(data%4==0 && data!=0 || data%4==0)
        {
            System.Console.WriteLine($"{data} is a leap year.");
        }
        else{
            System.Console.WriteLine($"{data} is a not leap year.");
        }
    }
}