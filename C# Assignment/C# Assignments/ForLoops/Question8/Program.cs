using System;
namespace Question8;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int k=1;
        for(int i=0;i<number;i++)
        {
            for(int s=0;s<number-i-1;s++)
                System.Console.Write(" ");
            for(int j=0;j<i+1;j++)
                {
                    if(k>0 && k<=9)
                    {
                        System.Console.Write(k++ + " ");
                    }
                    else{
                        System.Console.Write(k++ + " ");
                    }
                }
            System.Console.WriteLine();
        }
    }
}