using System;

namespace FilterDelegates
{
    public delegate bool FilterDelegate(Person p);
    public class Person
    {
        public string Name {get; set;}
        public int Age { get; set; }
    
   
}
}
