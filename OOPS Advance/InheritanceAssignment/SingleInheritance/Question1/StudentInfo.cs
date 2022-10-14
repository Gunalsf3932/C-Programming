using System;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNo=1000;
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }

        public StudentInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear):base(name,fatherName,phone,mail,dob,gender)
        {
            s_registerNo++;
            RegisterNumber="SID"+s_registerNo;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Student Details are: ");
            System.Console.WriteLine("Register Number: "+RegisterNumber+"\n"+"Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"Mail: "+Mail+"\n"+"Dob: "+Dob+"\n"+"Gender:"+Gender+"\n"+"Standard:"+Standard+"\n"+"Branch: "+Branch+"\n"+"Acadamic Year: "+AcadamicYear);
        }
    }
}
