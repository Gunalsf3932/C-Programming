using System;

namespace AbsractClasses
{
    public abstract class AbstractBase
    {
        protected string name;  //Normal field
        public  abstract string Name { get; set; }  //Abstract property

        public double Amount { get; set; }  //Normal Property

        public void Display()          //Normal Method
        {
            System.Console.WriteLine($"Name : {name}");
        }

        public abstract void Salary(int dates);  //Abstract Method 
        



    }
}
