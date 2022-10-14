using System;

namespace Question3
{
    public class Suzuki : CarInfo
    {
         public string CarModelNumber { get; set; }
        public string CarModelName { get; set; }

        public Suzuki(string engineNumber,string chasisNumber,double milage,double tankCapacity,int numberOfSeats,double numberOfKmDriven,DateTime dateOfPurchase,string carModelNumber,string carModelName):base(engineNumber, chasisNumber, milage, tankCapacity, numberOfSeats, numberOfKmDriven, dateOfPurchase)
        {
            
            CarModelNumber=carModelNumber;
            CarModelName=carModelName;
        }
        public void ShowSuzukiInfo()
        {
            ShowCarInfo();
            System.Console.WriteLine("Car Model Number : "+CarModelNumber);
            System.Console.WriteLine("Car Model Name : "+CarModelName);
        }
    }
}
