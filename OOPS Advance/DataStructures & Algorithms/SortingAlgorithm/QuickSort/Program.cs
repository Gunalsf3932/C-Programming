using System;
namespace QuickSort;
class Program 
{
    public static void Main(string[] args)
    {
        int [] arr={18,19,1,5,7,3,20};
        
        SortArray(arr);
        System.Console.WriteLine("Quick sorted.......");

        for(int i=0;i<arr.Length;i++)
        {
            if(i==0){
            System.Console.Write(arr[i]);
            }
            else{
                System.Console.Write(","+arr[i]);
            }
        }
    }
    static void SortArray(int[] arr)
    {
        Quick(arr,0,arr.Length-1);
    
    }   
    static void Quick(int[] arr,int first,int last)
    {
        int i=first;
        int j=last;
        int pivot =arr[(first+last)/2];

        while(i<=j)
        {
            while(arr[i]<pivot)
            {
                i++;
            }
            while(arr[j]>pivot)
            {
                j--;
            }

            if(i<=j)
            {
                int temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;

                i++;
                j--;
            }
        }
        if(first<j)
        {
            Quick(arr,first,j);
        }
        if(i<last)
        {
            Quick(arr,i,last);
        }
    }
}