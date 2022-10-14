using System;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
    }
}
