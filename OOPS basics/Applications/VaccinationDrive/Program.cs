using System;
namespace VaccinationDrive;
class Program 
{
    public static void Main(string[] args)
    {
        Files.Create();
        //Operation.DefaultData();
        Files.ReadFile();
        Operation.MainMenu();
        Files.WriteToFile();
    }
}