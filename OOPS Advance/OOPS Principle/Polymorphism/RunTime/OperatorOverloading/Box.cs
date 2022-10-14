using System;

namespace OperatorOverloading
{
    class Box
    {
        private double Length;
        private double Breadth;
        private double Height;

        public  Box (double length,double breadth,double height)
        {
            Length=length;
            Breadth=breadth;
            Height=height;

        }
        public Box()
        {

        }

        public double CalculateVolume()
        {
            return Length * Breadth * Height;
        }

        public static Box operator +(Box box1,Box box2)
        {
            Box box =new Box();
            box.Length=box1.Length+box2.Length;
            box.Breadth=box1.Breadth+box2.Breadth;
            box.Height=box1.Height+box2.Height;
            return box;
        }
    }
}
