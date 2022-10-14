using System;

namespace VirtualOverRide
{
    public class Puppy : Dog
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Puppy Sound!!");
        }
    }
}
