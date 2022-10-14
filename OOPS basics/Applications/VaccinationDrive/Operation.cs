using System;
using System.Collections.Generic;
namespace VaccinationDrive
{
    public class Operation
    {
       public  static List<Beneficiary> beneficiaryList=new List<Beneficiary>();
       public  static List<Vaccination> vaccinationList=new List<Vaccination>();
        public static List<Vaccine> vaccineList=new List<Vaccine>();
        static Beneficiary currentUser=null;
        public static void DefaultData()
        {
            Beneficiary user1=new Beneficiary("Ravichandran",Gender.Male,8484484,"Chennai",21);
            beneficiaryList.Add(user1);
            Beneficiary user2=new Beneficiary("Baskaran",Gender.Male,8484747,"Chennai",22);
            beneficiaryList.Add(user2);

            Vaccine user3=new Vaccine(VaccineName.Covishield,50);
            vaccineList.Add(user3);
            Vaccine user4=new Vaccine(VaccineName.Covaccine,50);
            vaccineList.Add(user4);

            Vaccination user5=new Vaccination(user1.RegisterNumber,user3.VaccineId,1,new DateTime(2021,11,11));
            vaccinationList.Add(user5);
            Vaccination user6=new Vaccination(user1.RegisterNumber,user3.VaccineId,2,new DateTime(2022,03,11));
            vaccinationList.Add(user6);
            Vaccination user7=new Vaccination(user2.RegisterNumber,user4.VaccineId,1,new DateTime(2022,04,04));
            vaccinationList.Add(user7);
        }

        public static void MainMenu()
        {
            string choice="";
            do{
                System.Console.WriteLine("Select the OPtion 1.Beneficiary Registration    2.Login  3.Get Vaccine Info 4.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Beneficiary Registration");
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
                        System.Console.WriteLine("Get Vaccine Info");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            System.Console.WriteLine("Are you Continue the Main Menu");
            choice=Console.ReadLine();
            
            }while(choice=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("User Details: ");
            System.Console.WriteLine("Enter the User Name: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter the Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());

            System.Console.WriteLine("Enter user Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the user City: ");
            string city=Console.ReadLine();
            
            System.Console.WriteLine("Enter the user Age: ");
            int age=int.Parse(Console.ReadLine());
            
            Beneficiary user3=new Beneficiary(name,gender,mobileNumber,city,age);
            beneficiaryList.Add(user3);
            
            System.Console.WriteLine("Registration Number: "+user3.RegisterNumber);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Registeration Number: ");
            string RegisterNumber=Console.ReadLine();
            
            foreach(Beneficiary user in beneficiaryList)
            {
                if(RegisterNumber==user.RegisterNumber)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice="";
            do{
                System.Console.WriteLine("Select the Option 1.Show My Details 2.Take Vaccination 3.My Vaccination History 4.Next Due Date 5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show My Details");
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Take Vaccination ");
                        ShowMyDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("My Vaccination History");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Next Due Date");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yse");
        }
        public static void ShowMyDetails()
        {
            
            
        }
    }    
}

