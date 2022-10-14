using System;
namespace DoWhile;
class program 
{
    public static void Main(string[] args)
    {
        int number;
        string choice=" ";
        do
        {
            System.Console.WriteLine("User enter the number: ");
            number=int.Parse(Console.ReadLine());

                if(number%2==0){
                    System.Console.WriteLine($"{number} is Even.");
                }
                else{
                    System.Console.WriteLine($"{number} is Odd.");
                }
            System.Console.WriteLine("Again need to ask Yes or No");
            choice=Console.ReadLine().ToLower();
                while(choice!="yes" && choice!="no")
                {
                    System.Console.WriteLine("Input is wrong Please enter valid input.");
                    choice=Console.ReadLine();
                    
                }
            
        }while(choice=="yes");
        
        
    }
}
