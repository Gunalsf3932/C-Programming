using System;
namespace MergeSort;
class Program 
{
    public static void Main(string[] args)
    {
        int [] arr={18,19,1,5,7,3,20};
        mergeSort(arr,0,arr.Length-1);
        foreach(int num in arr)
        {
            System.Console.Write(num+" ");
        }

        void mergeSort(int [] arr , int low , int high)
        {
            int mid;
            if(low<high)
            {
                mid=(low+high)/2;
                mergeSort(arr,low,mid);
                mergeSort(arr,mid+1,high);
                merge(arr,low,high,mid);
            }
            
        }
        void merge(int [] arr,int low,int high,int mid)
        {
            int i,j,k;
            int[] c=new int[arr.Length];
            i=low;
            k=low;
            j=mid+1;
            while(i<=mid && j<=high)
            {
                if(arr[i]<arr[j])
                {
                    c[k]=arr[i];
                    k++;
                    i++;
                }
                else{
                    c[k]=arr[j];
                    k++;
                    j++;
                }
            }
            while(i<=mid)
            {
                c[k]=arr[i];
                k++;
                i++;
            }
            while(j<=high)
            {
                c[k]=arr[j];
                k++;
                j++;
            }
            for(i=low;i<k;i++)
            {
                arr[i]=c[i];
            }

        }
    }
}