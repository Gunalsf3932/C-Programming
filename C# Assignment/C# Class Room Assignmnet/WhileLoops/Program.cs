using System;
namespace WhileLoops;
class program 
{
    public static void Main(string[] args)
    {
        

        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
            i++;    
        }   
        int number;
        System.Console.WriteLine("Enter the number");
        bool temp =int.TryParse(Console.ReadLine(),out number);

        while(temp!= true)
        {

            System.Console.WriteLine("Invalid input format. Please enter the input in number format");

            System.Console.WriteLine("Enter the number");
            temp =int.TryParse(Console.ReadLine(),out number);
            
        }
        System.Console.WriteLine(number);

    }
}

