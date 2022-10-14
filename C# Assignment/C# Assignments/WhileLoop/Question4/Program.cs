using System;
namespace Question4;
class program 
{
    public static void Main(string[] args)
    {
  
        int number;
        System.Console.WriteLine("Enter the number");
        bool temp =int.TryParse(Console.ReadLine(),out number);
        
        while(!temp || number>5) 
        {
         
            System.Console.WriteLine("Invalid input enter again");

            System.Console.WriteLine("Enter the number");
            temp =int.TryParse(Console.ReadLine(),out number);
        }
         if(number>0 && number<=5)
            {
                System.Console.WriteLine($"{number} is valid input ");
                
            }
    }
}
