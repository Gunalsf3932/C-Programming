using System;
namespace Question7;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Input");
        int input=int.Parse(Console.ReadLine());

        if(input<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if(input>=90 && input<130)
        {
            System.Console.WriteLine("Normal");
        }
        else if(input>=130 && input<140)
        {
            System.Console.WriteLine("medium");
        }
        else if(input>=140 && input<170)
        {
            System.Console.WriteLine("high sugar – try to reduce it from now");
        }
        else 
        {
            if(input>=170){
            System.Console.WriteLine("You are a very high Sugar Patient ");
            }
        }
        
    }
}