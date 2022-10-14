using System;

namespace Question3
{
    public class SalaryInfo : Attendance
    {
        public int SalaryOfTheMonth { get; set; }
        public string Month { get; set; }

        public SalaryInfo(DateTime date,int numberOfHoursWorked,int salaryOfTheMonth,string month):base(date, numberOfHoursWorked)
        {
            SalaryOfTheMonth=salaryOfTheMonth;
            Month=month;

        }
    }
}
