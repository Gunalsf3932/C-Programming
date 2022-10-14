using System;
namespace Question3;
class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int temp=number;
        int div,rev=0;
        while(temp!=0)
        {
            div=temp%10;
            rev=rev*10+div;
            temp=temp/10;
        }
        if(number==rev)
        {
            System.Console.WriteLine($"{number} is a Palindrome");
        }
        else{
            System.Console.WriteLine($"{number} is not a Palindrome");
        }
        
        
    }
}