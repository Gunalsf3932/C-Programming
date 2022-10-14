using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankOperation;
public class Operation 
{
    public static void MainMenu()
    {

        List<BankDetails> customerList=new List<BankDetails>();
        string willing="";

        do{

        System.Console.WriteLine("Enter the Customer Details:");

        System.Console.WriteLine("Enter Your Name: ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Father Name: ");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        
        System.Console.WriteLine("Enter Your DOB: dd/MM/yyyy");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter Your Account type: ");
        AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);
        
        BankDetails customer1=new BankDetails(name,fatherName,gender,dob,accountType);

        customerList.Add(customer1);
        
        System.Console.WriteLine("Customer Account Created.");

        System.Console.WriteLine($"Customer Account Number: {customer1.AccountNumber}");
        System.Console.WriteLine("Are You willing to create Bank Account");
        willing=Console.ReadLine().ToLower();
   
        }while(willing=="yes");

        foreach(BankDetails customer in customerList)
        {
            System.Console.WriteLine("Customer Details are: ");
            System.Console.WriteLine($"Customer Account Number: {customer.AccountNumber}");
            System.Console.WriteLine($"Name : {customer.Name}\nFather Name : {customer.FatherName}\nGender : {customer.Gender}\nDOB : {customer.Dob.ToString("dd/MM/yyyy")}\nAccountType : {customer.AccountType}\nBalance : {customer.Balance}");
            customer.Deposit();
            customer.WithDrawl();
            customer.ShowBalance();
     }
    }
}
