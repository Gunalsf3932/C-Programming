using System;
namespace Question2;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the count: ");
        int count=int.Parse(Console.ReadLine());
        int number=1;
        int square;
       
        int sum=0;
        while(number<=count)
        {
            System.Console.WriteLine(number + " ");
            square=number*number;
            sum =square+sum;
            
            number++;
            
        }
        System.Console.WriteLine($"Sum is {sum}");
        

    }
}