using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the nameOne: ");
        string nameOne=Console.ReadLine();

        System.Console.WriteLine("Enter the nameTwo: ");
        string nameTwo=Console.ReadLine();

        char[] name1=nameOne.ToCharArray();
        char[] name2=nameTwo.ToCharArray();

        for(int i=0;i<nameOne.Length;i++)
        {
            if(name1[i]==name2[i])
            {
                System.Console.WriteLine("Name one and two are anagrams");
            }
        }
    }
}