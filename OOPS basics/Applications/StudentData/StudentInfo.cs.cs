using System;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string Name { get; set; }
        public static int RegisterNumber;
        static StudentInfo()
        {
            Name="Gunal P";
            RegisterNumber=3932;
        }
        public static void Display()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"RegisterNumber : {RegisterNumber}");
        }
        
        
        
        
    }
}
