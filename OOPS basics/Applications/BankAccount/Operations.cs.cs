using System;
using System.Collections.Generic;

namespace BankAccount;


public static class Operations
{
    static BankDetails currentCustomer=null;
    static List<BankDetails> customerList=new List<BankDetails>();
    public static void MainMenu()

        {
            string choice="yes";
            do{
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            
            }while(choice=="yes");
        }
    public static void Registration()
    {
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

        System.Console.WriteLine($"Customer Account Number: {customer1.AccountNumber}");
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter your Acoountnumber");
        string accountNumber=Console.ReadLine();
        foreach(BankDetails customer in customerList)
        {
            if(customer.AccountNumber==accountNumber)
            {
                System.Console.WriteLine("Login Successful");
                currentCustomer=customer;
                SubMenu();

            }
        }
    }
    public static void SubMenu()
    {
        string choice="yes";
        do{
            System.Console.WriteLine("Select the number:");
            System.Console.WriteLine("Select 1.Show Details 2.Deposit 3.With Drawl 4.Show Balance 5.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Deposit");
                    currentCustomer.Deposit();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("With drawl");
                    currentCustomer.WithDrawl();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("show balance");
                    currentCustomer.ShowBalance();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
        }while(choice=="yes");
    }
}   
