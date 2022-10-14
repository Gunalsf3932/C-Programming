using System;

namespace ECommerse1
{
    public class CustomerDetails
    {
        public static int s_CustomerNumber=1000;
        public string CustomerId {get; set;}
        public string CustomerName { get; set; }
        public string City { get; set; } 
        public long PhoneNumber { get; set; }
        public string  MailId { get; set; }
        public double WalletBalance { get; set; }
      
        public CustomerDetails(string name,string city,long phone,string mailId,double walletBalance)
        {
            s_CustomerNumber++;
            CustomerId="CID"+s_CustomerNumber;
            CustomerName=name;
            City=city;
            PhoneNumber=phone;
            MailId=mailId;
            WalletBalance=walletBalance;

        }
    }
}
