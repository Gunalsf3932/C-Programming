using System;
namespace Question2;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a no 1,2,3,4,5,6,7: ");
        int number=int.Parse(Console.ReadLine());

        switch(number)
        {
            case 1 :
            {
                System.Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Tuesday");
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wednesday");
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Thursday");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Saturday");
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Sunday");
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