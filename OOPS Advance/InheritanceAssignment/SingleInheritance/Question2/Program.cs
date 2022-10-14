using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo customer=new AccountInfo("Gunal","Paruthimakalaingan",9566933459,"gunal35@gmail.com",new DateTime(2001,07,09),Gender.Male,"HDFC","HID100000",10.0);
        customer.ShowDetails();
    }
}