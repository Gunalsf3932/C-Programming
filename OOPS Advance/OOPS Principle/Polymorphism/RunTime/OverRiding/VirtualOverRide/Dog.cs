using System;

namespace VirtualOverRide
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog Sound!!");
        }

    
    }
}
