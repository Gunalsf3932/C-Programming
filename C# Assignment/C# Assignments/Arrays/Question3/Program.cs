using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("the number of elements to be stored in the array :");
        int value=int.Parse(Console.ReadLine());
        
        int[] arr=new Int32[value];
        int i,count=0;
        System.Console.WriteLine("3 elements in the array :");
        for(i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        for(i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine(arr[i]);
        }
        System.Console.WriteLine("Sum of all elements stored in the array is : ");
        for(i=0;i<arr.Length;i++)
        {
            count+=arr[i];
        }
        System.Console.WriteLine(count);
        
    }
}