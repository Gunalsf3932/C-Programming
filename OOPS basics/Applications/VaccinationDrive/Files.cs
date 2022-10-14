using System;

namespace VaccinationDrive
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Covid"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Covid");
            }
            if(!File.Exists("Covid/Beneficiary.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Covid/Beneficiary.csv");
            }
            if(!File.Exists("Covid/Vaccine.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Covid/Vaccine.csv");
            }
            if(!File.Exists("Covid/Vaccination.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Covid/Vaccination.csv");
            }
        }

        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("Covid/Beneficiary.csv");
            foreach(string data in users)
            {
                Beneficiary beneficiary1=new Beneficiary(data);
                Operation.beneficiaryList.Add(beneficiary1);
            }

            string[] vaccines1=File.ReadAllLines("Covid/Vaccine.csv");
            foreach(string data in vaccines1)
            {
                Vaccine vaccine1=new Vaccine(data);
                Operation.vaccineList.Add(vaccine1);
            }

            string[] vaccination1=File.ReadAllLines("Covid/Vaccination.csv");
            foreach(string data in vaccination1)
            {
                Vaccination vaccination=new Vaccination(data);
                Operation.vaccinationList.Add(vaccination);
            }
            
        }
        public static void WriteToFile()
        {
            string[] BeneficiaryDetails=new string[Operation.beneficiaryList.Count];
            for(int i=0;i<Operation.beneficiaryList.Count;i++)
            {
                BeneficiaryDetails[i]=Operation.beneficiaryList[i].RegisterNumber+","+Operation.beneficiaryList[i].Name+","+Operation.beneficiaryList[i].Gender+","+Operation.beneficiaryList[i].MobileNumber+","+Operation.beneficiaryList[i].City+","+Operation.beneficiaryList[i].Age;

            }
            File.WriteAllLines("Covid/BeneficiaryDetails.csv",BeneficiaryDetails);

            string[] vaccineDetails=new string[Operation.vaccineList.Count];
            for(int i=0;i<Operation.vaccineList.Count;i++)
            {
                vaccineDetails[i]=Operation.vaccineList[i].VaccineId
            }


        }
        
    }
}
