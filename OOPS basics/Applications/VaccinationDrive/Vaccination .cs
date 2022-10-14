using System;

namespace VaccinationDrive
{
   
    public class Vaccination 
    {
       public static int s_vaccination=1001;
       public string VaccinationID { get; set; }
       public string RegisterNumber { get; set; }
       public string VaccineId { get; set; }
       public int DoseNumber { get; set; }
       public DateTime VaccinatedDate { get; set; }
       public Vaccination(string registerNumber,string vaccineId,int doseNumber,DateTime vaccinatedDate)
       {
        s_vaccination++;
        VaccinationID="VID"+s_vaccination;
        RegisterNumber=registerNumber;
        VaccineId=vaccineId;
        DoseNumber=doseNumber;
        VaccinatedDate=vaccinatedDate;
       }
       public Vaccination(string data)
       {
        string[] values=data.Split(',');
        s_vaccination=int.Parse(values[0].Remove(0,3));
        VaccinationID=values[0];
        RegisterNumber=values[1];
        VaccineId=values[2];
        DoseNumber=int.Parse(values[3]);
        VaccinatedDate=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
       }
    }
}
