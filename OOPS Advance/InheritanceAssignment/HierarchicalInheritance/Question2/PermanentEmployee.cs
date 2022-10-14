using System;

namespace Question2
{
    public class PermanentEmployee
    {
        private static int s_employeeId=1000;
        public string EmployeeId { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }

        public PermanentEmployee(string employeeType,double dA,double hRA,double pF,double totalSalary)
        {
            s_employeeId++;
            EmployeeId="PEID"+s_employeeId;
            EmployeeType=employeeType;
            DA=dA;
            HRA=hRA;
            PF=pF;
            TotalSalary=totalSalary;

        }
    }
}
