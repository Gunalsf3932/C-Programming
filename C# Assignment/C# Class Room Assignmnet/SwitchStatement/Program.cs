using System;

namespace SwitchStatement;

class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value1:");
        int value1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value2:");
        int value2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation + - * / %: ");
        char operation=Convert.ToChar(Console.ReadLine());
         
        switch(operation)
         {
            case '+':
            {
                int addition=value1+value2;
                Console.WriteLine($"Result= {addition}");
                break;
            }
            case '-':
            {
                int subtraction=value1-value2;
                Console.WriteLine($"Result= {subtraction}");
                break;
                
            }
            case '*':
            {
                int multiplication =value1*value2;
                Console.WriteLine($"Result= {multiplication}");
                break;
            }
            case '/':
            {
                double division=value1/value2;
                Console.WriteLine($"Result= {division}");
                break;
            }
            case '%':
            {
                double moduloDivision=value1%value2;
                Console.WriteLine($"Result {moduloDivision}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }

    }
}
