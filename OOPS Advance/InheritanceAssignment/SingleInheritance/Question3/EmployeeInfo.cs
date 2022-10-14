using System;

namespace Question3
{
    public enum Gender{Male,Female}
    public class EmployeeInfo : SalaryInfo
    {
        private static int s_employeeId=1000;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Branch { get; set; }

        public EmployeeInfo(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string branch,DateTime date,int numberOfHoursWorked,int salaryOfTheMonth,string month):base(date, numberOfHoursWorked,salaryOfTheMonth,month)
        {
            s_employeeId++;
            EmployeeID="EID"+s_employeeId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            Dob=dob;
            Branch=branch;
        }

        public void Show()
        {
            System.Console.WriteLine("Details are: ");
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Father Name: "+FatherName);
            System.Console.WriteLine("Gnder: "+Gender);
            System.Console.WriteLine("Mobile Number: "+MobileNumber);
            System.Console.WriteLine("Dob: "+Dob);
            System.Console.WriteLine("Branch: "+Branch);
            System.Console.WriteLine("Date: "+Date);
            System.Console.WriteLine("NumberOfHoursWorked: "+NumberOfHoursWorked);
            System.Console.WriteLine("salaryOfTheMonth: "+SalaryOfTheMonth);
             System.Console.WriteLine("Month: "+Month);

            
        }
    }
}
