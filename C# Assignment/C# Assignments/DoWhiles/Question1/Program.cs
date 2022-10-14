using System;
namespace Question1;
class program 
{
    public static void Main(string[] args)
    {
        int number;
        string choice=" ";
        do{
            System.Console.WriteLine("Enter the number: ");
            number=int.Parse(Console.ReadLine());
            
            if(number%2==0)
            {
                System.Console.WriteLine("Result: Given number is Even number");
            }
            else{
                System.Console.WriteLine("Result: Given number is Odd number");
            }
        System.Console.WriteLine("Enter your choice");
        choice=Console.ReadLine().ToLower();
        
        }while(choice=="yes");
    }
}