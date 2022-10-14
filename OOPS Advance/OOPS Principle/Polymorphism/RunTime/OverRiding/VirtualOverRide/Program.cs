using System;
namespace VirtualOverRide;
class Program 
{
    public static void Main(string[] args)
    {
        Dog dog=new Dog();
        dog.MakeSound();

        Puppy puppy=new Puppy();
        puppy.MakeSound();
        
    }
}