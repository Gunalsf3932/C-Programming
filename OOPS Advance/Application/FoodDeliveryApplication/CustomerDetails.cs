using System;

namespace FoodDeliveryApplication
{
    public class CustomerDetails : PersonalDetails , IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get; set; }
        public int WalletBalance { get; set; }

        public CustomerDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId,string location,int walletBalance) : base(name,fatherName,gender,mobileNumber,dob,mailId,location) 
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            WalletBalance=walletBalance;
        }

        public CustomerDetails(string data)
        {
            string [] values=data.Split(',');
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            MobileNumber=long.Parse(values[4]);
            Dob=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MailId=values[6];
            Location=values[7];
            WalletBalance=int.Parse(values[8]);
            
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to be recharged ");
            int walletBalance=int.Parse(Console.ReadLine());

            WalletBalance += walletBalance;
            System.Console.WriteLine("Amount Recharged successfully");
            
        }


    }
}
