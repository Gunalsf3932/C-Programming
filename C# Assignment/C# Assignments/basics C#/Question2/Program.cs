using System;

namespace Question2;

class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the first number: ");
        int value1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        int value2=Convert.ToInt32(Console.ReadLine());

        int addition=value1+value2;
        int subtraction=value1-value2;
        int multiplication=value1*value2;
        int division=value1/value2;
        int moduloDivision= value1%value2;

        Console.WriteLine($"Input the first number: {value1}");
        Console.WriteLine($"Input the second number: {value2}");
        Console.WriteLine("Expected Output: ");
        Console.WriteLine($"{value1} + {value2} = {addition}");
        Console.WriteLine($"{value1} + {value2} = {subtraction}");
        Console.WriteLine($"{value1} + {value2} = {multiplication}");
        Console.WriteLine($"{value1} + {value2} = {division}");
        Console.WriteLine($"{value1} + {value2} = {moduloDivision}");


    }
}