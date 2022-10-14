using System;
namespace Question5;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Country name India,Pakistan,Bangladesh: ");
        string choice=Console.ReadLine();
        
        switch(choice)
        {
            case "India":
            {
                System.Console.WriteLine("1. Gambir");
                System.Console.WriteLine("2. Ashwin");
                System.Console.WriteLine("3. Dhoni");
                System.Console.WriteLine("4. Jadeja");
                break;
            }
            case "Pakistan":
            {
                System.Console.WriteLine("1. Afridi");
                System.Console.WriteLine("2. BaberAzam");
                System.Console.WriteLine("3. risvan");
                break;
            }
            case "Bangladesh":
            {
                System.Console.WriteLine("1. Root");
                System.Console.WriteLine("2. Brovo");
                System.Console.WriteLine("3. Holder");
                break;
            }
            default:
            {
                System.Console.WriteLine("Please enter valid input");
                break;
            }
        }
    }
}