using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        string reverse=" ";
        System.Console.WriteLine("Enter the string: ");
        string name=Console.ReadLine();
        
        char[] ch=name.ToCharArray();
        Array.Reverse(ch);

        reverse=new string(ch);
        if(name==reverse)
        {
            System.Console.WriteLine($"{name} is a Palindrome");
        }
        else{
            System.Console.WriteLine($"{name} is not a palindome");
        }
    }
}