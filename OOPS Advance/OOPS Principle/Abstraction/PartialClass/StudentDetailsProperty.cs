using System;

namespace PartialClass
{
    public partial class StudentDetails
    {
         public static int s_StudentId=1002;
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public int Physics { get; set;}
        public int Chemistry { get; set; }
        public int Maths { get; set; }

    }
}
