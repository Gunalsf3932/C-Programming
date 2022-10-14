using System;

namespace Question4
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}
