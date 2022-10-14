using System;
namespace Question5;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int terms=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=terms*2;i++)
        {
            if(i%2!=0)
            {
                System.Console.Write(i+" ");
                sum=sum+i;
                
            }
        
        }
        System.Console.WriteLine($"The Sum of odd Natural Number upto 10 terms :{sum}");
    }
}