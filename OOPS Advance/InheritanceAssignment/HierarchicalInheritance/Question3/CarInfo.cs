using System;

namespace Question3
{
    public class CarInfo
    {
        private static int s_rcBookNo=1000;
        public string RcBookNo { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public double Milage { get; set; }
        public double TankCapacity { get; set; }
        public int NumberOfSeats { get; set; }
        public double NumberOfKmDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public CarInfo(string engineNumber,string chasisNumber,double milage,double tankCapacity,int numberOfSeats,double numberOfKmDriven,DateTime dateOfPurchase)
        {
            s_rcBookNo++;
            RcBookNo="RBNO"+s_rcBookNo;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            Milage=milage;
            TankCapacity=tankCapacity;
            NumberOfSeats=numberOfSeats;
            NumberOfKmDriven=numberOfKmDriven;
            DateOfPurchase=dateOfPurchase;

        }
        public void ShowCarInfo()
        {
            System.Console.WriteLine("Rc Book No : "+RcBookNo);
            System.Console.WriteLine("EngineNumber : "+EngineNumber);
            System.Console.WriteLine("ChasisNumber : "+ChasisNumber);
            System.Console.WriteLine("Milage : "+Milage);
            System.Console.WriteLine("TankCapacity : "+TankCapacity);
            System.Console.WriteLine("NumberOfSeats : "+NumberOfSeats);
            System.Console.WriteLine("NumberOfKmDriven : "+NumberOfKmDriven);
            System.Console.WriteLine("DateOfPurchase : "+DateOfPurchase);
        }
    }
}
