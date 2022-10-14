using System;
namespace Question11;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string Name: ");
        string name=Console.ReadLine();
            
            
        System.Console.WriteLine("After removing duplicates characters from the said string: ");
        for(int i=0;i<name.Length;i++)
        {
            for(int j=i+1;j<name.Length;j++)
            {
            if(name[i] == name[j])
        {
            System.Console.Write( name[i]);
        }

            }
        }
       
    }
}