using System;

namespace Interface
{
    public class Draw : Irectangular
    {
        public double area { get; set; }
        public double Length { get; set; }
        public double Breath { get; set; }

        public void CalculateArea()
        {

            area=Length*Breath;
            System.Console.WriteLine("Area is : "+area);
        }

    }
}
