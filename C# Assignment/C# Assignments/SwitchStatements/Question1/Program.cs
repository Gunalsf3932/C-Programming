using System;
namespace Question1;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input E,V,G,A,F: ");
        char input=Convert.ToChar(Console.ReadLine());

        switch(input)
        {
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
            case 'V' :
            {
                System.Console.WriteLine("Very Good ");
                break;
            }
            case 'G' :
            {
                 System.Console.WriteLine("Good");
                 break;
            }
            case 'A':
            {
                System.Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default:
            {
                System.Console.WriteLine("Not Valid");
                break;
            }
        }
    }
}