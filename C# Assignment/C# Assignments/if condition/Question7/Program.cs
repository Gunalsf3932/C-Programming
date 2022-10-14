using System;
namespace Question7;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Customer IDNO :");
        int id=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Customer Name :");
        string name=(Console.ReadLine());

        System.Console.WriteLine("unit Consumed :");
        int unit=int.Parse(Console.ReadLine());
        
        double charge;
        double surcharge;
        double billAmount;

        if(unit>=0 && unit<=50)
        {
            charge=0;
            surcharge=0;
            billAmount=100;
            System.Console.WriteLine($"customer Name: {name}\n customer ID: {id}\n units consumed:{unit}\n Amount Charges: @Rs.{charge}\n Surchage Amount {surcharge}\n Net Amount Paid By the Customer {billAmount}\n");
       
        }
        else if(unit>50 && unit<=199)
        {
            charge=1.20*unit;
            surcharge=0;
            billAmount=charge;
            System.Console.WriteLine($"customer Name: {name}\n customer ID: {id}\n units consumed:{unit}\n Amount Charges @RS.1.20per unit:{charge}\n Surchage Amount {surcharge}\n Net Amount Paid By the Customer {billAmount}\n");

        }
        else if(unit>200 && unit<=400)
        {
            charge=1.50*unit;
            surcharge=0;
            billAmount=charge;
            System.Console.WriteLine($"customer Name: {name}\n customer ID: {id}\n units consumed:{unit}\n Amount Charges @RS.1.50 per unit:{charge}\n Surchage Amount {surcharge}\n Net Amount Paid By the Customer {billAmount}\n");
        }
        else if(unit>400 && unit<=600)
        {
            charge=1.80*unit;
            surcharge=charge*0.15;
            billAmount=charge+surcharge;
            System.Console.WriteLine($"customer Name: {name}\n customer ID: {id}\n units consumed:{unit}\n Amount Charges @RS.1.80 per unit:{charge}\n Surchage Amount {surcharge}\n Net Amount Paid By the Customer {billAmount}\n");
        }
        else if(unit>600)
        {
            charge=2.00*unit;
            surcharge=charge*0.15;
            billAmount=charge+surcharge;
            System.Console.WriteLine($"customer Name: {name}\n customer ID: {id}\n units consumed:{unit}\n Amount Charges @RS.2.00 per unit:{charge}\n Surchage Amount {surcharge}\n Net Amount Paid By the Customer {billAmount}\n");
        }



        
    }
}