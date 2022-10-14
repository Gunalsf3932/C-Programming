using System;
using System.IO;

namespace OnlineMedicalStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MedicalStore"))
            {
                System.Console.WriteLine("Creating Medical Folder");
                Directory.CreateDirectory("MedicalStore");
            }
             if(!File.Exists("MedicalStore/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating UserDetails File");
                File.Create("MedicalStore/UserDetails.csv");
            }
            if(!File.Exists("MedicalStore/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creating MedicineDetails File");
                File.Create("MedicalStore/MedicineDetails.csv");
            }
            if(!File.Exists("MedicalStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating OrderDetails File");
                File.Create("MedicalStore/OrderDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string [] users=File.ReadAllLines("MedicalStore/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user=new UserDetails(data);
                Operations.userList.AddElement(user);
            }

            string [] medicines=File.ReadAllLines("MedicalStore/MedicineDetails.csv");
            foreach(string data in medicines)
            {
                MedicineDetails medicine=new MedicineDetails(data);
                Operations.medicineList.AddElement(medicine);
            }

            string[] orders=File.ReadAllLines("MedicalStore/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.AddElement(order);
            }
        }
        public static void WriteToFile()
        {
            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserId+","+Operations.userList[i].UserName+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;

            }
            File.WriteAllLines("MedicalStore/UserDetails.csv",userDetails);

            string[] medicineDetails=new string[Operations.medicineList.Count];
            for(int i=0;i<Operations.medicineList.Count;i++)
            {
                medicineDetails[i] = Operations.medicineList[i].MedicineId+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvailableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");

            }
            File.WriteAllLines("MedicalStore/MedicineDetails.csv",medicineDetails);

            string[] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderId+","+Operations.orderList[i].UserId+","+Operations.orderList[i].MedicineId+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalStore/OrderDetails.csv",orderDetails);
        }
    }
}
