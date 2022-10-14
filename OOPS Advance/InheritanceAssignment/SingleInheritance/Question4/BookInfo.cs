using System;

namespace Question4
{
    public class BookInfo : DepartmentDetails
    {
        private static int s_bookId=1000;
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public BookInfo(string departmentName,string degree,string bookName,string authorName,int price) : base(departmentName,degree)
        {
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void show()
        {
            System.Console.WriteLine("Details are: ");
            System.Console.WriteLine("Department Name : "+DepartmentName);
            System.Console.WriteLine("Degree : "+Degree);
            System.Console.WriteLine("Book Id : "+BookId);
            System.Console.WriteLine("Book Name : "+BookName);
            System.Console.WriteLine("Author Name : "+AuthorName);
            System.Console.WriteLine("Price : "+Price);

        }
    }
}
