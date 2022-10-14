using System;
namespace Array;

class program 
{
    public static void Main(string[] args)
    {
        string[] names=new string[5];
        for(int i=0;i<names.Length;i++)
        {
            System.Console.WriteLine("Enter the names: ");
            names[i]=Console.ReadLine();         
        }
        for(int i=0;i<names.Length;i++)
        {
            System.Console.WriteLine(names[i]);
        }
        System.Console.WriteLine("Enter the name:");
        string search=Console.ReadLine();
        int temp =0;
        for(int i=0;i<names.Length;i++)
        {
            if(search==names[i])
            {
                System.Console.WriteLine($"The name is present in array {names[i]} of the {i} ");
                temp++;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("The not present in array");
        }

        
        foreach( string myNames in names)
        {
            if(search==myNames)
            {
                System.Console.WriteLine($"The name is present in array {myNames}   ");
                temp++;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("The not present in array");
        }

        
    }
}    
        


        

        

        
        
    