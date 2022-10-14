using System;

namespace VaccinationDrive
{
 public enum VaccineName {Covishield, Covaccine}   
  public class Vaccine
    {
         public static int s_vaccine=101;
        public string VaccineId { get; set; }
        public VaccineName VaccineName { get; set; }
        public int NoOfDoseAvailable { get; set; }
        public Vaccine(VaccineName vaccineName,int noOfDoseAvailable)
        {
            s_vaccine++;
            VaccineId="CID"+s_vaccine;
            VaccineName=vaccineName;
            NoOfDoseAvailable=noOfDoseAvailable;
        }
        public Vaccine(string data)
        {
            string[] values=data.Split(',');
            s_vaccine=int.Parse(values[0].Remove(0,3));
            VaccineId=values[0];
            VaccineName=Enum.Parse<VaccineName>(values[1]);
            NoOfDoseAvailable=int.Parse(values[2]);
        }
    }
}
