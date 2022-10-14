using System;

namespace LibraryManagement
{
    public enum Status1{Assigned,Returned}
    public class BorrowDetails
    {
        public static int s_borrow=301;
        public string BorrowID { get; set; }
        public string BookID { get; set; }
        public string RegistrationID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Status Status1 { get; set; }
        
        
        public BorrowDetails(string bookID,string registrationID,DateTime borrowedDate,Status status1)
        {
            s_borrow++;
            BorrowID="BID"+s_borrow;
            BookID=bookID;
            RegistrationID=registrationID;
            BorrowedDate=borrowedDate;
            Status1=status1;
            
        }
    }
}
