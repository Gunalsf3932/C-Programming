using System;
namespace InsertionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int [] arr={18,19,1,5,7,3,20};
        int i,j,temp;

        for(i=1;i<arr.Length;i++)
        {
            for(j=i-1;j>0;j--)
            {
                if(arr[j]<arr[j-1])
                {
                    temp=arr[j];
                    arr[j]=arr[j-1];
                    arr[j-1]=temp;
                    
                }
                
            }
            
        }
        System.Console.WriteLine("Insertion Sorted.......");
        for(i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]+" ");
        }
    }
}
