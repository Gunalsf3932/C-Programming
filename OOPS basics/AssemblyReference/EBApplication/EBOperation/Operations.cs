using System;
using System.Collections.Generic;
using EBLibrary;
namespace EBOperation;
public class Operations 
{
    public static void MainMenu()
    {
        List<EbDetails> ebList=new List<EbDetails>();
        string willing="";
        do{
        System.Console.WriteLine("Enter the Details: ");

        System.Console.WriteLine("Enter your Name: ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Phone Number: ");
        long phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail Id: ");
        string mailId=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Units used: ");
        int units=int.Parse(Console.ReadLine());

        EbDetails details=new EbDetails(name,phone,mailId,units);
        
        ebList.Add(details);
        System.Console.WriteLine("Are you enter next Eb Details: ");
        willing=Console.ReadLine().ToLower();
        
        }while(willing=="yes");

        foreach(EbDetails eb in ebList)
        {
            System.Console.WriteLine("The Details are: ");
            System.Console.WriteLine($"Meter Id: {eb.MeterId}\nUser Name: {eb.Name}\nPhone Number: {eb.Phone}\nMail Id: {eb.MailId}\nUnits used: {eb.Units}");
            eb.Calculate();

        }
    }
}