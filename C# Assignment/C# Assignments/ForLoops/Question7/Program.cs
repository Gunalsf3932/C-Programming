﻿using System;
namespace Question7;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());

        for(int i=0;i<number;i++)
        {
            for(int s=0;s<number-i-1;s++)
                System.Console.Write(" ");
            for(int j=0;j<i+1;j++)
                System.Console.Write("* ");
            System.Console.WriteLine();
        }    
    }
}