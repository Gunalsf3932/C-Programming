using System;

namespace Question5 
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Physics Mark: ");
            int physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry Mark: ");
            int chemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maths Mark: ");
            int maths=Convert.ToInt32(Console.ReadLine());

            double sum=physics+chemistry+maths;
            
            double percentage=Math.Round(sum/300*100);            
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Percentage = {percentage}");


        }
    }
}