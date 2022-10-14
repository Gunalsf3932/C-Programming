using System;

namespace Question3
{
    public class Attendance
    {
        public DateTime Date { get; set; }
        public int NumberOfHoursWorked { get; set; }
        
        public Attendance(DateTime date,int numberOfHoursWorked)
        {
            Date=date;
            NumberOfHoursWorked=numberOfHoursWorked;
        }
    }
}
