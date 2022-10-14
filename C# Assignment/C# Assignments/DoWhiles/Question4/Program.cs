using System;
namespace Question4;
class program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number");
        bool temp =int.TryParse(Console.ReadLine(),out number);
        do{
        
        
        
        while(!temp || number>10) 
        {
         
            System.Console.WriteLine("Invalid input enter again");

            System.Console.WriteLine("Enter the number");
            temp =int.TryParse(Console.ReadLine(),out number);
        }
        if(number>0 && number<=10)
            {
                System.Console.WriteLine($"{number} is valid input ");
                
            }
            Console.ReadLine();
            
         
        }while(number>0 );
        
        
    }
}