using System;

namespace GroceryShop
{
    public class CustomerDetails : PersonalDetails ,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get; set; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId,double walletBalance):base(name,fatherName,gender,mobileNumber,dob,mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
           

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
            WalletBalance=double.Parse(values[7]);
            
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to be recharged ");
            double walletBalance=int.Parse(Console.ReadLine());

            WalletBalance += walletBalance;
            System.Console.WriteLine("Amount Recharged successfully");
            System.Console.WriteLine("Balance "+WalletBalance);
            
        }
        public void ShowCustomerDetails()
        {
          System.Console.WriteLine($"Customer Id : {CustomerId}  Name : {Name} Father Name : {FatherName} Gender : {Gender} Mobile Number : {MobileNumber} Dob : {Dob.ToString("dd/MM/yyyy")}  MailId : {MailId} WalletBalance : {WalletBalance}");
        }
    }
}
