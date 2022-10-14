using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value1:");
        int value1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the value2: ");
        int value2=int.Parse(Console.ReadLine());

        int sum=Addition(value1,value2);
        System.Console.WriteLine("The Addition is:"+sum);

        int difference=Subtraction(value1,value2);
        System.Console.WriteLine("The Subtraction is:"+difference);

        int multiply=Multiplication(value1,value2);
        System.Console.WriteLine("The Multiplication is:"+multiply);

        int divide=Division(value1,value2);
        System.Console.WriteLine("The Division is:"+divide);
        
        int Addition(int value1,int value2)
        {
            int difference;
            difference=value1+value2;
            return difference;
        }        
        int Subtraction(int value1,int value2)
        {
            int sum;
            sum=value1-value2;
            return sum;
        }
        int Multiplication(int value1,int value2)
        {
            int multiply;
            multiply=value1*value2;
            return multiply;
        }    
        int Division(int value1,int value2)
        {
            int divide;
            divide=value1/value2;
            return divide;
        }

    }
}