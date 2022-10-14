using System;

namespace  MultipleInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails : PersonalDetails ,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }  //Property declaration only allowed
         public int Chemistry{get; set;}
         public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base ( aid,name, fatherName, gender,phoneNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;            
        }

        public void GetMark(int physics,int chemistry,int maths){
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3.0;
        }

        public void ShowMark()
        {
            System.Console.WriteLine("Physics: "+Physics+"Chemistry: "+Chemistry+"Maths :"+Maths);
            System.Console.WriteLine("Total : "+Total+("\t")+"Average : "+Average);
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id : "+StudentID );
            ShowDetails();
            System.Console.WriteLine("Department : "+ Department+ "\n Year: "+Year);

        }
    }
}
