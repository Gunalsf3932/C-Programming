﻿using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the row");
        int row=int.Parse(Console.ReadLine());

        
        for(int i=0;i<=row;i++)
        {
            for(int j=1;j<=i;j++)
            {
                System.Console.Write("*");
              
            }
            System.Console.WriteLine("\n");
        }
        

        
    }
}