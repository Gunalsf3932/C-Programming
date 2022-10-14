using System;
namespace Question2;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a candidate age: ");
        int age=int.Parse(Console.ReadLine());

        if(age>=18)
        {
            System.Console.WriteLine("Congratulation! ");
            System.Console.WriteLine("You are eligible for casting your vote.");
        }
        else{
            System.Console.WriteLine("You are not eligible for casting your vote.");
        }
    }
}