using System;

namespace Question2
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string branchName,string iFSCCode,double balance):base(name,fatherName,phone,mail,dob,gender)
        {
            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Balance=balance;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Customer Details are:");
            System.Console.WriteLine("Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"Mail: "+Mail+"Dob: "+Dob+"\n"+"Gender: "+Gender+"\n"+"Account Number: "+AccountNumber+"\n"+"Branch Name:"+BranchName+"\n"+"IFSCCode: "+IFSCCode+"\n"+"Balance: "+Balance);
        }
    }
}
