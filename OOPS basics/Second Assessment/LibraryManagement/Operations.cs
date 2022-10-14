using System;
using System.Collections.Generic;
namespace LibraryManagement
{
    public class Operations
    {
        static List<UserDetails> userList=new List<UserDetails>();
        static List<BorrowDetails> borrowList=new List<BorrowDetails>();
        static List<BookDetails> bookList=new List<BookDetails>();
        static UserDetails currentUser=null;

        public static void DefaultData()
        {
            UserDetails user1=new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com");
            userList.Add(user1);
            UserDetails user2=new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com");
            userList.Add(user2);

            BookDetails book1=new BookDetails("C#","Author1",3,Status.Returned);
            bookList.Add(book1);
            BookDetails book2=new BookDetails("HTML","Author2",5,Status.Issued);
            bookList.Add(book2);
            BookDetails book3=new BookDetails("CSS","Author1",3,Status.Returned);
            bookList.Add(book3);
            BookDetails book4=new BookDetails("JS","Author1",3,Status.Issued);
            bookList.Add(book4);
            BookDetails book5=new BookDetails("Ts","Author2",2,Status.Returned);
            bookList.Add(book5);


        }
         public static void MainMenu()
        {
            string choice="";
            do{
                System.Console.WriteLine("Select the Option 1.User Registration  2.Login  3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                System.Console.WriteLine("Enter your choice");
                choice=Console.ReadLine();

            }while(choice=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter the User Details: ");

            System.Console.WriteLine("Enter User Name: ");
            string userName=Console.ReadLine();
            
            System.Console.WriteLine("Enter User Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());

            System.Console.WriteLine("Enter User Department: ");
            Department department=Enum.Parse<Department>(Console.ReadLine());

            System.Console.WriteLine("Enter User Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter User Mail ID: ");
            string mailID=Console.ReadLine();
            
            UserDetails user3=new UserDetails(userName,gender,department,mobileNumber,mailID);
            userList.Add(user3);

            System.Console.WriteLine("Registration ID: "+user3.RegistrationID);
            
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration Id: ");
            string userId=Console.ReadLine();
            
            foreach(UserDetails user in userList)
            {
                if(userId==user.RegistrationID)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user;
                    SubMenu();

                }
                else{
                    System.Console.WriteLine("Invalid User ID");
                }
            }

        }

        public static void SubMenu()
        {
            string choice="";
            do{
                System.Console.WriteLine("Select the Option 1.Borrow Book  2.Show Borrowed History  3.Return Books  4.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Borrow Book ");
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show Borrowed history");
                        ShowBorrowedHistory();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Return Books");
                        ReturnBook();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                System.Console.WriteLine("Enter your choice");
                choice=Console.ReadLine();
                
            }while(choice=="yes");
        }
        
        public static void BorrowBook() 
        {
            
            System.Console.WriteLine("Book Details are: ");
            foreach(BookDetails book in bookList)
            {
                System.Console.WriteLine(book.BookID+"\t"+ book.BookName+"\t"+book.AuthorName+"\t"+book.Count+"\t");
            }
            System.Console.WriteLine("Enter the Book ID: ");
            string bookId=Console.ReadLine();
            
           int count=0;

            foreach(BookDetails book2 in bookList)
            {
                if(bookId==book2.BookID)
                {
                    //check book count availability
                    if(book2.Count>1)
                    {
                        //user already borrowed any book
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if(borrow.RegistrationID==currentUser.RegistrationID && borrow.Status1==Status.Issued)
                            {
                                count++;
                            }
                        
                                if(count<=3)
                                {
                                BorrowDetails borrow1=new BorrowDetails(borrow.BookID,borrow.RegistrationID,DateTime.Now,borrow.Status1);
                                borrowList.Add(borrow1);
                                book2.Count--;
                                System.Console.WriteLine("Borrow id is: "+borrow.RegistrationID);  
                                }
                                else{
                                    System.Console.WriteLine("Book not Assigned");
                                }
                        }    
                            
                            
                        }
                    }
                    else{
                        System.Console.WriteLine("Books not available ");
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if(book2.BookID==borrow.BookID)
                            {
                                if(borrow.Status1==Status.Issued)
                                {
                                    System.Console.WriteLine("Next available date of book is: "+borrow.BorrowedDate.AddDays(15));
                                }
                            }
                        }
                    
                    }
                }
                
            }
            
        
        public static void ShowBorrowedHistory()
        {
            foreach(BorrowDetails borrow in borrowList)
            {
                if(borrow.RegistrationID==currentUser.RegistrationID){
                     System.Console.WriteLine("Borrow ID: "+borrow.BorrowID);
                     System.Console.WriteLine("Borrow Book Id: "+borrow.BookID);
                     System.Console.WriteLine("Borrow RegisterId: "+borrow.RegistrationID);
                     System.Console.WriteLine("Borrow Date: "+borrow.BorrowedDate);
                     System.Console.WriteLine("Borrow Status: "+borrow.Status1);
                    
                }
            }
        }    

        public static void  ReturnBook()
        {
            foreach(BorrowDetails borrow2 in borrowList)
            {
                if(currentUser.RegistrationID==borrow2.RegistrationID)
                {
                  TimeSpan one =DateTime.Now-borrow2.BorrowedDate.AddDays(15);
                  int a=one.Days;
                    if(a>0)
                    {
                        System.Console.WriteLine("Borrow Id: {borrow2.BorrowID}\t{borrow2.BookID}\t Borrow Date: {borrow2.BorrowedDate}\t Return Date: {borrow2.BorrowedDate.AddDays(15)}\t Charge={a*1}");
                        System.Console.WriteLine("Do you want to return the book");
                        string option =Console.ReadLine().ToLower();
                        if(option=="yes")
                        {
                            System.Console.WriteLine("Enter Borrow ID");
                            string bId=Console.ReadLine().ToUpper();
                            if(borrow2.BorrowID==bId)
                            {
                                if(borrow2.Status1==Status.Issued)
                                {
                                    System.Console.WriteLine("Book Returned successfully");
                                    foreach(BookDetails book in bookList)
                                    {
                                        if(borrow2.BookID==book.BookID)
                                        {
                                            book.Count++;
                                            borrow2.Status1=Status.Returned;
                                        }
                                        else{
                                            System.Console.WriteLine("Book already Returned");
                                        }
                                    }
                                }
                            }
                            else{
                                a=0;
                                System.Console.WriteLine($"Borrow Id: {borrow2.BorrowID}\t Book Id{borrow2.BookID}\t Borrow Date{borrow2.BorrowedDate}\t {borrow2.Status1}");

                                System.Console.WriteLine("Do you want to return the book");
                                string option1=Console.ReadLine().ToLower();
                                
                                if(option1=="yes")
                                {
                                    System.Console.WriteLine("Enter Borrow Id");
                                    string bId1=Console.ReadLine();
                                    if(borrow2.BookID==bId1)
                                    {
                                        if(borrow2.Status1==Status.Issued)
                                        {
                                            System.Console.WriteLine("Book Returned Successfully");
                                            foreach(BookDetails book in bookList)
                                            {
                                                if(borrow2.BookID==book.BookID)
                                                {
                                                    book.Count++;
                                                    borrow2.Status1=Status.Returned;
                                                }
                                            }
                                        }
                                        else{
                                            System.Console.WriteLine("Booke Already Returned");
                                        }
                                    }
                                }
                                
                            }
                            
                        }
                        
                    }
                        


                    }
                }
            }
        } 




    }

