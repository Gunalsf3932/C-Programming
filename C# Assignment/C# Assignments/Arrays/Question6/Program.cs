using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("The number of elements stored in the array:");
        int number=int.Parse(Console.ReadLine());
        
        int[] arr=new Int32[number];
        int i,temp;
        System.Console.WriteLine($"{number} elements in the array: ");
        for(i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        
        for(i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i] > arr[j])
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
