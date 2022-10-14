using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a character:");
        char word=char.Parse(Console.ReadLine());

        if(word=='a' || word=='A' || word=='e' || word=='E' || word=='i' || word=='I' || word=='o' || word=='O' || word=='u' || word=='U')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else{
            System.Console.WriteLine("It is not a vowel");
        }
        
    }
}