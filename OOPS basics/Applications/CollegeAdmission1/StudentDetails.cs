using System;
/// <summary>
/// Used to process the college admission using this application
/// </summary>
namespace CollegeAdmission1
{
    /// <summary>
    /// used to select a student the gender information 
    /// </summary>
    public enum Gender { Default,Male,Female,Transgender}
    /// <summary>
    /// class <see cref="StudentDetails"> used to collect student details
    /// </summary>
    public class StudentDetails
    {
        /// <summary>
        /// used to auto increment the register number
        /// </summary>
        private static int s_registerNumber=3000;
        /// <summary>
        /// Property RegisterNumber used to uniquely identify a <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
      
        public string RegisterNumber { get;  }
        
        /// <summary>
        /// Property Name used to provide sudent name <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        public string Name { get; set; } 
        /// <summary>
        /// Property FatherName used to provide Student Father Name <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Property DOB used to provide Student DateOfBirth <see cref="StudentDetails">
        /// </summary>
        /// <value></value>

        public DateTime DOB { get; set; }
        /// <summary>
        /// Property Gender used to provide Student Gender <see cref="StudentDetails">
        /// </summary>
        /// <value></value>

        public Gender Gender { get; set; }
        /// <summary>
        /// Property Phone used to provide Student Phone Number <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Property Mail used to provide Student Mail ID <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// Property Physics user provide  Student Physics Mark <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        public int Physics { get; set; }
        /// <summary>
        /// Property Chemistry user provide Student Chemistry mark <see cref="StudentDetails">
        /// </summary>
        /// <value></value>

        public int Chemistry { get; set; }
        /// <summary>
        /// Property Maths user provide Studetent Maths mark <see cref="StudentDetails">
        /// </summary>
        /// <value></value>
        
        public int Maths { get; set; }
        /// <summary>
        /// Constructor of <see cref="StudentDetails" /> class used to initialize values to its properties
        /// </summary>
        /// <param name="name"> Parameter name used to initialize a Student's Name to Name Property</param>
        /// <param name="fatherName">Parameter fatherName used to initialize a Student's FatherName to FatherName Property</param>
        /// <param name="dob">Parameter dob used to initialize a Student's Dob to DOB Property</param>
        /// <param name="gender">Parameter gender used to initialize a Student's Gender to Gender Property</param>
        /// <param name="phone">Parameter phone used to initialize a Student's PhoneNo to Phone Property</param>
        /// <param name="mail">Parameter mail used to initialize a Student's MailId to Mail Property</param>
        /// <param name="physics">Parameter physics used to initialize a Student's PhysicsMark to Physics Property</param>
        /// <param name="chemistry">Parameter chemistry used to initialize a Student's ChemistryMark to Chemistry Property</param>
        /// <param name="maths">Parameter maths used to initialize a Student's MathsMark to Maths</param>

        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,long phone,string mail,int physics,int chemistry,int maths)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
           
        }
        /// <summary>
        /// Method CheckElligiblity get cutoff from student and checking Eligiblity of student
        /// if cutoff is less or equal then he is eligible and return true else false 
        /// </summary>
        /// <param name="cutoff"></param>
        /// <returns>Return true if eligible else false</returns>
        public bool CheckEligiblity(double cutoff)
        {
            double average= (double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutoff)
            {
                return true;
            }
            else{
                return false;
            }
        }
        /// <summary>
        ///  Property ShowDetails is used to print all the student Details
        /// </summary>
        public void ShowDetails()
        {
        System.Console.WriteLine("Student Details are: ");
        System.Console.WriteLine($"Strudent Register Number: {RegisterNumber}");
        System.Console.WriteLine($"Name : {Name}\nFather Name : {FatherName}\nDOB : {DOB}\nGender : {Gender}\nPhone No : {Phone}\nMail Id : {Mail}\nPhysics Mark : {Physics}\nChemistry Mark : {Chemistry}\nMaths Mark : {Maths}");
        }

    }
}