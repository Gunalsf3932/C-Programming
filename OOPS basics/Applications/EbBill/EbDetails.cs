using System;
namespace EbBill
{
    public class EbDetails
    {
        private static int s_meterId=1000;

        public string MeterId { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        
        
        public string MailId { get; set; }
        public int Units { get; set; }

       

        public EbDetails(string name,long phone,string mailId)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            Name=name;
            Phone=phone;
            MailId=mailId;
        
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("The Details are: ");
            System.Console.WriteLine($"Meter Id: {MeterId}\nUser Name: {Name}\nPhone Number: {Phone}\nMail Id: {MailId}\nUnits used: {Units}");
        }
        public void NoOfUnits()
        {
            System.Console.WriteLine("Enter the units: ");
            int Units=int.Parse(Console.ReadLine());

        }
        public void Calculate(int Units)
        {
            int charge;

            if(Units>0 && Units<=100)
            {
                charge=0;
                System.Console.WriteLine("EB Bill Amount : "+charge);
            }
            else if(Units>100 && Units<=200)
            {
                charge=3*Units;
                System.Console.WriteLine("EB Bill Amount : "+charge);
            }
            else if(Units>200 && Units<=400)
            {
                charge=5*Units;
                System.Console.WriteLine("EB Bill Amount : "+charge);
            }
            else{
                charge=6*Units;
                System.Console.WriteLine("EB Bill Amount : "+charge);
            }


        }
        
        
        
        
        
        
        
        
    }
}