using System;

namespace Question2
{
    public class TemporaryEmployee
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double TotalSalary { get; set; }

        public TemporaryEmployee(string employeeType,double dA,double hRA,double totalSalary)
        {
            s_employeeID++;
            EmployeeID="TEID"+s_employeeID;
            EmployeeType=employeeType;
            DA=dA;
            HRA=hRA;
            TotalSalary=totalSalary;
        }
    }
}
