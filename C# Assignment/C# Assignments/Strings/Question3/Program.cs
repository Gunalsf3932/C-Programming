using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        string reverse=" ";
        System.Console.WriteLine("Enter the string name:");
        string name=Console.ReadLine();
        char[] ch=name.ToCharArray();
        Array.Reverse(ch);
        reverse=new string(ch);
       System.Console.WriteLine(" The characters of the string in reverse are :");
        for (int i=0;i<reverse.Length;i++)
        {
            System.Console.Write(" "+reverse[i]);
        }

        
    }
}