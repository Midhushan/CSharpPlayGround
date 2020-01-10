using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 22 / 7;
            double r;
            Console.WriteLine("Enter Rdius : ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {0}", areaCircle);
            Console.WriteLine();


        }
    }
}
