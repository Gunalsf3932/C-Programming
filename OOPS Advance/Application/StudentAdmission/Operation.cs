using System;


namespace StudentAdmission
{
    public delegate void EventManager();
    public static class Operation
    {
        public static event EventManager eventlink=null;
        public static List<StudentDetails> studentList=new List<StudentDetails>();
        public static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();

        static StudentDetails currentStudent=null;
       
     /*  public static void DefaultData()
        {
            StudentDetails student1=new StudentDetails("RaviChandran E","Ettaparajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
           studentList.Add(student1);
           StudentDetails student2=new StudentDetails("Baskaran S","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
           studentList.Add(student2);   

            DepartmentDetails department1=new DepartmentDetails("EEE",29);
            departmentList.Add(department1);
            DepartmentDetails department2=new DepartmentDetails("CSE",29);
            departmentList.Add(department2);
            DepartmentDetails department3=new DepartmentDetails("MECH",30);
            departmentList.Add(department3);
            DepartmentDetails department4=new DepartmentDetails("ECE",30);
            departmentList.Add(department4);

            AdmissionDetails admission1=new AdmissionDetails("SF1001","DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
            admissionList.Add(admission1);
            AdmissionDetails admission2=new AdmissionDetails("SF1002","DID103",new DateTime(2022,05,11),AdmissionStatus.Admitted);
            admissionList.Add(admission2);
        }   */

        public static void Subscibe()
        {
            eventlink += new EventManager (Files.Create);
            eventlink += new EventManager (Files.ReadFile);
            eventlink += new EventManager (Operation.MainMenu);
            eventlink += new EventManager (Files.WriteToFiles);
        }
        public static void StartEvent()
        {
            Subscibe();
            eventlink();
        }
        public static void MainMenu()
        {
           
            string choice="";
            do{
               System.Console.WriteLine("Enter the option 1.Registeration 2.Login 3.Check Department wise seat avaliablebility 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    
                    case 1:
                    {
                        System.Console.WriteLine("Registeration");
                        Registeration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Check Department wise seat avaliablebility");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                    
            
                    
                }
            System.Console.WriteLine("Enter the choice: ");
            choice=Console.ReadLine();

            }while(choice=="yes");
        }
        public static void Registeration()
        {
            System.Console.WriteLine("Enter the Details: ");

            System.Console.WriteLine("Enter the Student Name: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter the Student Father Name: ");
            string fatherName=Console.ReadLine();
            
            System.Console.WriteLine("Enter the date Of birth dd/MM/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Enter the student gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter your Physics Mark");
            int physics=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry Mark");
            int chemistry=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths Mark");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student=new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
            studentList.Add(student);

            System.Console.WriteLine($"Student Registeration {student.RegisterNumber}");
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Student Id Number: ");
            string studentId=Console.ReadLine();
            
            foreach(StudentDetails student1 in studentList)
            {
                if(studentId==student1.RegisterNumber)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentStudent=student1;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Invalid Student Id");
                }
            }

        }
        public static void SubMenu()
        {
            string choice="";
            do{
            System.Console.WriteLine("Enter your choice 1.Check Eligiblity 2.Show Details 3.Take Admission 4.Cancel Admission 5.ShowAdmissionDetails 6.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Check Eligiblity");
                    bool eligibility=currentStudent.CheckEligiblity(75.0);
                    if(eligibility)
                    {
                        System.Console.WriteLine("You are eligible");
                    }
                    else{
                        System.Console.WriteLine("You are not eligible");
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Show Details");
                    currentStudent.ShowDetails();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Take Admission");
                    TakeAdmission();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Cancel Admission");
                    CancelAdmission();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Show Admission Details");
                    ShowAdmissionDetails();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            System.Console.WriteLine("Enter the choice");
            choice=Console.ReadLine();
            
            }while(choice=="yes");
            
        }
        public static void TakeAdmission()
        {
            System.Console.WriteLine("Department Details: ");
            foreach(DepartmentDetails department1 in departmentList)
            {
                System.Console.WriteLine(department1.DepartmentName+"\t"+department1.NumberOfSeats);
            }
            System.Console.WriteLine("Please choose department Id");
            string departmentId=Console.ReadLine();
            
            foreach(DepartmentDetails department2 in departmentList)
            {
                if(DepartmentDetails.DepartmentId==departmentId)
                {
                    if(department2.NumberOfSeats>=1)
                    {
                        bool eligible=currentStudent.CheckEligiblity(75.0);
                        if(eligible)
                        {
                            System.Console.WriteLine("you are eligible");
                            bool candidateAdmit=true;
                            foreach(AdmissionDetails admission in admissionList)
                            {
                                if(admission.StudentId==currentStudent.RegisterNumber)
                                {
                                    if(admission.AdmissionStatus==AdmissionStatus.Admitted)
                                    {
                                        System.Console.WriteLine("You are already Admitted");
                                        candidateAdmit=false;
                                    }
                                }
                            }
                            if(candidateAdmit)
                            {
                                foreach(DepartmentDetails deptseats in departmentList)
                                {
                                    if(departmentId==DepartmentDetails.DepartmentId)
                                    {
                                        deptseats.NumberOfSeats--;
                                        AdmissionDetails admission3=new AdmissionDetails(currentStudent.RegisterNumber,departmentId,DateTime.Now,AdmissionStatus.Admitted);
                                        admissionList.Add(admission3);
                                        System.Console.WriteLine("You are Admitted !! Your Admission Id: "+admission3.AdmissionId);
                                    }
                                }
                            }
                        }
                    }
                    else{
                        System.Console.WriteLine("No seats are Available");
                    }
                }

            }
        }
        public static void CancelAdmission()
        {
            foreach(AdmissionDetails cancelAdmission in admissionList)
            {
                if(cancelAdmission.StudentId==currentStudent.RegisterNumber)
                {
                    foreach(DepartmentDetails cancel in departmentList)
                    {
                        if (cancelAdmission.AdmissionStatus==AdmissionStatus.Admitted && DepartmentDetails.DepartmentId ==cancelAdmission.DepartmentId)
                        {
                            cancelAdmission.AdmissionStatus=AdmissionStatus.Cancelled;
                            cancel.NumberOfSeats++;

                            System.Console.WriteLine("Admission cancelled");
                        }
                    }
                }
            }
        }
        public static void ShowAdmissionDetails()
        {
            foreach(AdmissionDetails admission in admissionList)
            {
                if(currentStudent.RegisterNumber==admission.StudentId)
                {
                    System.Console.WriteLine("Student Id: "+admission.StudentId);
                    System.Console.WriteLine("DepartMent ID : "+ admission.DepartmentId);
                    System.Console.WriteLine("Admission ID: "+ admission.AdmissionId);
                    System.Console.WriteLine("Admission Date: "+admission.AdmissionDate);
                    System.Console.WriteLine("Admission Status: "+ admission.AdmissionStatus);
                }
            }
        }


   
    }

}
