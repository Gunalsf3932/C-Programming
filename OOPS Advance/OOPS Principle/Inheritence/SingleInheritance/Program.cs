﻿using System;
using System.Collections.Generic;
namespace SingleInheritance;
class Program 
{
    
    public static void Main(string[] args)
    {
       PersonalDetails person=new PersonalDetails("Gunal","Paruthimakalaingan",Gender.Male,9566933459);
       person.ShowDetails();

       StudentDetails student=new StudentDetails("444555","Gunal","Paruthimakalaingan",Gender.Male,9566933459,Department.CSE,"Final Year");
       student.ShowStudent();
    }
    
}