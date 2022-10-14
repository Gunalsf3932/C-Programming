using System;

namespace Question3;

class program 
{
   public static void Main(string[] args)
   {
    Console.WriteLine("Enter the amount of Celsius: ");
    int celsius= Convert.ToInt32(Console.ReadLine());

    double kelvin = celsius+273.15;
    int fahrenheit = celsius * 9/5;
    int fahrenheit1= fahrenheit+32;

    
    Console.WriteLine($"Kelvin = {kelvin}");
    Console.WriteLine($"Fahrenheit = {fahrenheit1}");


   } 
}