using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the mark: ");
        int mark=int.Parse(Console.ReadLine());

        if(mark>0 && mark<=100)
        {
            System.Console.WriteLine("Less than 100");
        }        
        else if(mark>100 && mark<=200)
        {
            System.Console.WriteLine("Between 100 and 200");
        }
        else{
            System.Console.WriteLine("Greater than 200");
        }
    }
}