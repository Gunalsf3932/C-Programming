using System;

namespace MultipleInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerId=1000;
        public string CustomerID { get; set; }
        public double Balance { get; set; }

        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber):base ( aid,name, fatherName, gender,phoneNumber)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;

        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge");
            Balance+=double.Parse(Console.ReadLine());
            
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("Customer Id : "+CustomerID);
            ShowDetails();
            System.Console.WriteLine("Balance : "+ Balance);

        }
    }
}
