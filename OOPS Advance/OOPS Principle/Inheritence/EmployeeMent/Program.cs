using System;
using System.Collections.Generic;
namespace EmployMent;
class Program 
{
    
    public static void Main(string[] args)
    {
       PersonalDetails Person=new PersonalDetails("Gunal","Paruthimakalaingan",Gender.Male,9566933459);
       Person.ShowDetails();

    }
    
}