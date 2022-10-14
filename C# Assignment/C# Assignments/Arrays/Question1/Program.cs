using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        
        
        int[] arr=new Int32[10];
        int i;
        System.Console.WriteLine("Enter the elements");
        for(i=0;i<arr.Length;i++)
        {
            
            arr[i]=Convert.ToInt32(Console.ReadLine());
        
        }
        System.Console.WriteLine("Elements in Array are: ");
        for(i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]);
        }        
    }
}