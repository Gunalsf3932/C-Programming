using System;
namespace SelectionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] arr={18,19,1,5,7,3,20};

        int i,j,minimum,minIndex,temp;
        
        for(i=0;i<arr.Length;i++)
        {
            minimum=arr[i];
            minIndex=i;
            for(j=i;j<arr.Length;j++)
            {
                if(arr[j] < minimum)
                {
                    minimum=arr[j];
                    minIndex=j;
                }
            }
            if(minimum<arr[i])
            {
                temp=arr[i];
                arr[i]=arr[minIndex];
                arr[minIndex]=temp;
            }
        }

        System.Console.WriteLine("Selsection Sorted.....");
        
        for(i=0;i<arr.Length;i++)
        {
            if(i==0)
            {
            System.Console.Write(arr[i]);
            continue;
            }
            else{
                System.Console.Write(","+arr[i]);
            }
        }
    }
}
