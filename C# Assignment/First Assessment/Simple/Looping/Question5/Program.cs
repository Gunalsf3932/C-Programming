using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number: ");
        int number=int.Parse(Console.ReadLine());
        int count=0;
        for(int i=0;i<=number;i++)
        {
            if(i%number==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            System.Console.WriteLine("It is a Prime Number");
        }
        else{
            System.Console.WriteLine("It is not a Prime Number");
        }
    }
}