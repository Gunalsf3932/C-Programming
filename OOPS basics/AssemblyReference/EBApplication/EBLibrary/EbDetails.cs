namespace EBLibrary
{
    public class EbDetails
    {
        private static int s_meterId=1000;

        public string MeterId { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        
        
        public string MailId { get; set; }
        public int Units { get; set; }

       

        public EbDetails(string name,long phone,string mailId,int units)
        {
            s_meterId++;
            MeterId="SF"+s_meterId;
            Name=name;
            Phone=phone;
            MailId=mailId;
            Units=units;
        }
        public void Calculate()
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