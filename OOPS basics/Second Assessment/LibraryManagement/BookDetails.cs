using System;

namespace LibraryManagement
{
    public enum Status{Issued,Returned}
    public class BookDetails
    {
        public static int s_book=100;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Count { get; set; }
        public Status Status { get; set; }
        

        public BookDetails(string bookName,string authorName,int count,Status status)
        {
            s_book++;
            BookID="BID"+s_book;
            BookName=bookName;
            AuthorName=authorName;
            Count=count;
            Status=status;
        }
    }
}
