using System;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
