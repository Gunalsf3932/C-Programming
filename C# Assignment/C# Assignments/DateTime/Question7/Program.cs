using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the DateTime1:");
        DateTime dateTime1=new DateTime(2016,08,01,00,00,00);
        System.Console.WriteLine("Enter the DateTime2:");
        DateTime dateTime2=new DateTime(2016,08,01,12,00,00);

        int result=DateTime.Compare(dateTime1,dateTime2);

        string str;
        if(result<0)
        {
            str="Is Earlier than";
        }
        else if(result==0)
        {
            str="Same Time";
        }
        else{
            str="Is Later than";
        }
        System.Console.WriteLine($"{dateTime1} {str} {dateTime2}");
    }
} 