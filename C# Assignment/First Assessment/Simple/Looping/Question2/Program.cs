using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
       int sum=0;
       int count=0;
        for(int i=1;i<99;i++)
        {
            
            if(i%2!=0)
            {
                sum=(i*i);
                count+=sum;
                System.Console.WriteLine(sum);
            }
             
        }
       
    }
}