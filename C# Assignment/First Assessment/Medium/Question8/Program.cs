using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string name=Console.ReadLine();
        int sum=0;
        for(int i=0;i<name.Length;i++)
        {
            if(name[i]>'0' && name[i]<='9')
            {
                sum+=name[i]-48;
            }
        }
         if(sum%2==0)
         {
            System.Console.WriteLine("Even Number");
         }
          
     
    }
}