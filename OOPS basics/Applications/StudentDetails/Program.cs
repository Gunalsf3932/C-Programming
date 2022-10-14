using System;

namespace StudentDetails;

class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------Student Details-------");
        
        Console.WriteLine("Enter the Name: ");
        string stutentName= Console.ReadLine();

        Console.WriteLine("Enter the Father Name: ");
        string fatherName= Console.ReadLine();

        Console.WriteLine("Enter the Mail-Id: ");
        string mailId= Console.ReadLine();

        Console.WriteLine("Enter the Phone No: ");
        long phoneNo= Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter the Age: ");
        long age= Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter the Gender: ");
        string gender= Console.ReadLine();
        
        Console.WriteLine("Enter a Chemistry Mark: ");
        int chemistryMark= Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Enter a Physics Mark: ");
        int physicsMark= Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Enter a Maths Mark: ");
        int mathsMark= Convert.ToInt32(Console.ReadLine());

        int total=chemistryMark+physicsMark+mathsMark;
        float average=total/3;
        
        float percentage=total/6;
        
        Console.WriteLine($"Average is {average} and Percentage is {percentage} ");

        Console.WriteLine("------Student Details-------");
        Console.WriteLine($"Student Name: {stutentName}");
        Console.WriteLine($"Father Name: {fatherName}");
        Console.WriteLine($"Mail Id: {mailId}");
        Console.WriteLine($"Phone No: {phoneNo}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Chemistry Mark: {chemistryMark}");
        Console.WriteLine($"Physics Mark: {physicsMark}");
        Console.WriteLine($"Maths Mark: {mathsMark}");
        Console.WriteLine($"Average : {average}");
        Console.WriteLine($"Percentage : {percentage}");
    }
}

