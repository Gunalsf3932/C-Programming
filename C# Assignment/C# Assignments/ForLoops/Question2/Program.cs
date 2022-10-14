using System;
namespace Question2;
class program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<=10;i++)
        {
           sum=sum+i;
           

        }
        double average=(double)sum/10;
        System.Console.WriteLine($"Sum = {sum}");
        System.Console.WriteLine($"Average = {average}");
    }
}