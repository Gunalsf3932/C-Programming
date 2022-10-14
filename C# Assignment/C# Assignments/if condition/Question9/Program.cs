using System;
namespace Question9;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input: ");
        string input=(Console.ReadLine());
        
        if(input=="December" || input=="January" || input=="February")
        {
            System.Console.WriteLine("winter");
        }
        else if(input=="March" || input=="April" || input=="May")
        {
            System.Console.WriteLine("spring");
        }
        else if(input=="June" || input=="July" || input=="August")
        {
            System.Console.WriteLine("summer");
        }
        else
        {
            if(input=="September" || input=="October" || input=="November")
            {
                System.Console.WriteLine("rainfall");
            }
        }
        
    }
}
