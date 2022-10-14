using System;
namespace BankAccount
{
public enum Gender { Default,Male,Female,Transgender}
public enum AccountType { Default,SB,FD,RD}
    public class BankDetails
    {
        private static int s_accountNumber=1000;
        public string AccountNumber {get;}
        public string Name { get; set; }
        
        public string FatherName { get; set; }
        
        public string Male { get; set; }
        public Gender Gender { get; set; }
        
        public DateTime Dob { get; set; }
        
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }
        

        public BankDetails(string name,string fatherName,Gender gender,DateTime dob,AccountType accountType)
        {
            s_accountNumber++;
            AccountNumber="HDFC"+s_accountNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Dob=dob;
            AccountType=accountType;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Customer Details are: ");
            System.Console.WriteLine($"Customer Account Number: {AccountNumber}");
            System.Console.WriteLine($"Name : {Name}\nFather Name : {FatherName}\nGender : {Gender}\nDOB : {Dob.ToString("dd/MM/yyyy")}\nAccountType : {AccountType}\nBalance : {Balance}");
        }
        public void Deposit()
        {
            System.Console.WriteLine("Enter amount for deposit");
            int deposit=int.Parse(Console.ReadLine());

            Balance+=deposit;
            System.Console.WriteLine($"Your Current Balance {Balance}");
            
        }
        public void WithDrawl()
        {
            System.Console.WriteLine("Enter amount for Withdrawl");
            int withDrawl=int.Parse(Console.ReadLine());
            if(Balance>withDrawl)
            {
            Balance-=withDrawl;
            System.Console.WriteLine($"Your Current Balance {Balance}");
            }
            else
            {
                System.Console.WriteLine("Insufficient balance in your account");
            }
            
        }
        public void ShowBalance()
        {
            System.Console.WriteLine($"Current Balance in your account{Balance}");
        }
    }
}