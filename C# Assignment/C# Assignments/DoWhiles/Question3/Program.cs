﻿using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {   int terms;
       do{
        System.Console.WriteLine("Enter the number of terms: ");
        terms=int.Parse(Console.ReadLine());
        
        int i=0;
        int a=-1;
        int b=1;
        int c;
        while(i<=terms-1)
        {
            c=a+b;
            System.Console.WriteLine(c);
            a=b;
            b=c;
            i++;
        }
            
        }while(terms>0);
         
       
        
        
        
    }
    
}