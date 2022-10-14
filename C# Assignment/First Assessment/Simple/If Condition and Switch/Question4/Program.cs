using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: ");
        string month=Console.ReadLine();

        System.Console.WriteLine("Enter the taking leave: ");
        int leave=int.Parse(Console.ReadLine());
        int sum=0;
        int total;
        switch(month)
        {
            case "january":
            {
                sum=31-leave;
                total=500-sum;
                System.Console.WriteLine(total);
                break;
            }
            case "febrauary":
            {
                sum=28-leave;
                total=500-sum;
                System.Console.WriteLine(total);
                break;
            }
            case "march":
        }
    }
}