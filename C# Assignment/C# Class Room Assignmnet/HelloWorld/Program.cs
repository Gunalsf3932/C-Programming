using System;

namespace HelloWorld;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        var myName= Console.ReadLine();

        Console.WriteLine("Enter your father name");
        var fatherName= Console.ReadLine();

        Console.WriteLine("Your name is: "+myName+" Your father name is: "+fatherName );

    }
}


