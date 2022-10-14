using System;

namespace StudentAdmission
{
    public enum Gender {Male,Female,TransGender}
    public class StudentDetails
    {
        public static int s_StudentId=1000;
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public int Physics { get; set;}
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,int physics,int chemistry,int maths)
        {
            s_StudentId++;
            RegisterNumber="SF"+s_StudentId;
            Name=name;
            FatherName=fatherName;
            Dob=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public StudentDetails(string data)
        {
            string[] values=data.Split(',');
            s_StudentId=int.Parse(values[0].Remove(0,2));
            RegisterNumber=values[0];
            Name=values[1];
            FatherName=values[2];
            Dob=DateTime.Parse(values[3]);
            Gender=Enum.Parse<Gender>(values[4]);
            Physics=int.Parse(values[5]);
            Chemistry=int.Parse(values[6]);
            Maths=int.Parse(values[7]);
        }

        public bool CheckEligiblity(double cutoff)
        {
            double average=(Physics+Chemistry+Maths)/3.0;
            if(average>=cutoff)
            {
                return true;
            }
            else{
                return false;
            }
 
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("The Student Details are: ");
            System.Console.WriteLine($"Register Number : {RegisterNumber}\n Student Name: {Name}\nFather Name: {FatherName}\nDateOfBirth: {Dob}\nGender: {Gender}\nPhysics: {Physics}\nChemistry: {Chemistry}\nMaths: {Maths}");
        }

    }
}
