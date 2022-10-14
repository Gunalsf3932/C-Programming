using System;
using System.Collections.Generic;
namespace EbBill;

public static class Operations
{
    static EbDetails currentCustomer=null;
    static  List<EbDetails> ebList=new List<EbDetails>();
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
            System.Console.WriteLine("Enter the Details: ");

        System.Console.WriteLine("Enter your Name: ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Phone Number: ");
        long phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail Id: ");
        string mailId=Console.ReadLine();
        
      

        EbDetails details=new EbDetails(name,phone,mailId);
        
        ebList.Add(details);
        System.Console.WriteLine($"Meter Id are :{details.MeterId}");
        }
        public static void Login()
        {
        System.Console.WriteLine("Enter your Meter Id: ");
        string meterId=Console.ReadLine();
        foreach(EbDetails customer in ebList)
        {
            if(customer.MeterId==meterId)
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
            System.Console.WriteLine("Select 1.Show Cutomer Details 2.No of unit 3.Calculate unit 4.Exit");
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
                    System.Console.WriteLine("No of unit");
                    currentCustomer.NoOfUnits();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate unit");
                    currentCustomer.Calculate(currentCustomer.Units);
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
        }while(choice=="yes");
    }
    
}

