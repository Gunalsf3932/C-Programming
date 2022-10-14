using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("The number of elements to be stored in the array :");
        int number=int.Parse(Console.ReadLine());

        int[] arr=new Int32[number];
        int i,max=arr[0],min=arr[0];
        System.Console.WriteLine(" 3 Elements in the array: ");
        for(i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        for (i=0;i<arr.Length-1;i++)
        {
            if(arr[i]>max)
            {
                max=arr[i];
            }
            if(arr[i]<min)
            {
                min=arr[i];
            }

            
        }
        System.Console.WriteLine(max);
        System.Console.WriteLine(min);
        
        
    }
}