using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("The number of elements stored in the array:");
        int number=int.Parse(Console.ReadLine());
        
        int[] arr=new Int32[number];
        int i;
        for(i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        System.Console.WriteLine("---");
        for(i=0;i<arr.Length;i++){
        if(arr[i]%2==0)
        {
            System.Console.WriteLine(arr[i]);
        }
        else
        {
            System.Console.WriteLine(arr[i]);
        }
        }
    }
}