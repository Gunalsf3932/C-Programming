using System;
namespace Question4;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input1: ");
        int input1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the input2: ");
        int input2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the input 1,2,3,4,5: ");
        int choice=int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"The Addition of {input1} and {input2} option 1 ");
                System.Console.WriteLine($"Addition= {input1+input2}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The Substraction of {input1} and {input2} option 2 ");
                System.Console.WriteLine($"Substraction= {input1-input2}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The Multiplication of {input1} and {input2} option 3 ");
                System.Console.WriteLine($"Multiplication= {input1*input2}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The Division of {input1} and{input2} option 4 ");
                System.Console.WriteLine($"Division= {input1/input2}");
                break;
            }
            case 5:
            {
                
                System.Console.WriteLine("Exit");
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