using System;
using System.Collections.Generic;
namespace BubbleSort;
class Program 
{
    public static void Main(string[] args)
    {
        int temp;
        int[] arr={18,19,1,5,7,3,20};
        
        System.Console.WriteLine("Bubble Sorrted ...");
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]>arr[j])
                {
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                    
                }
            }
            System.Console.Write(arr[i]+" ");
        }
        
    }
}