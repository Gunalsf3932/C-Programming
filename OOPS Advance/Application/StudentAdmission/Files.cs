using System;

namespace StudentAdmission
{
    public static  class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating College Folder");
                Directory.CreateDirectory("College");

            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating StudentDetails File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating AdmissionDetails File");
                File.Create("College/AdmissionDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating Department File");
                File.Create("College/DepartmentDetails.csv");
            }
            
        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");

            foreach(string data in students)
            {
                StudentDetails student = new StudentDetails(data);
                Operation.studentList.Add(student);
            }
            string [] departments=File.ReadAllLines("College/DepartmentDetails");

            foreach(string data in departments)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operation.departmentList.Add(department); 
            }

            string[] admissions=File.ReadAllLines("College/admissionDetails");

            foreach(string data in admissions)
            {
                AdmissionDetails admission=new AdmissionDetails(data);
                Operation.admissionList.Add(admission);

            }

            
        }

        public static void WriteToFiles()
        {
            string[] studentDetails=new string[Operation.studentList.Count];
            for(int i=0;i<Operation.studentList.Count;i++)
            {
                studentDetails[i]=Operation.studentList[i].RegisterNumber+","+Operation.studentList[i].Name+","+Operation.studentList[i].FatherName+","+Operation.studentList[i].Dob.ToShortDateString()+","+Operation.studentList[i].Gender+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);


            string [] departmentDetails=new string[Operation.departmentList.Count];
            for (int i=0;i<Operation.departmentList.Count;i++)
            {
                departmentDetails[i]=Operation.departmentList[i].DepartmentName+","+Operation.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);

            string[] admissionDetails=new string[Operation.admissionList.Count];
            for(int i=0;i<Operation.departmentList.Count;i++)
            {
                admissionDetails[i]=Operation.admissionList[i].AdmissionId+","+Operation.admissionList[i].DepartmentId+","+Operation.admissionList[i].AdmissionDate.ToShortDateString()+","+Operation.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);
        }
    }
}
