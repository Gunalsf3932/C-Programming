using System;

namespace MultilevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employeId=1000;
        public string EmployeeId { get; set; }

        public DateTime RegistrationDate {get; set;}

        public EmploymentDetails(string studentID,string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(studentID,aid,name,fatherName,gender,phoneNumber,department)
        {
            s_employeId++;
            EmployeeId="EId"+s_employeId;
            RegistrationDate=DateTime.Now;
        }
        public void ShowEmploymentDetails()
        {
            System.Console.WriteLine("EmployeeId: "+EmployeeId);
            ShowStudent();
            System.Console.WriteLine("Registration Date: "+RegistrationDate.ToString("dd/MM/yyyy"));
        }
    }
}
