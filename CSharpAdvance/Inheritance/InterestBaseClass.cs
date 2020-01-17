using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public abstract class InterestBaseClass
    {
        public double Principle { get; set; }
        public double RateOfInterest { get; set; }
        public int NoOfYears { get; set; }
        public double IntrestAmount { get; protected set; }

        //public InterestBaseClass(double Principle) { }
        public InterestBaseClass(double Principle, double RateOfInterest, int NoOfYears)
        {
            this.Principle = Principle;
            this.RateOfInterest = RateOfInterest;
            this.NoOfYears = NoOfYears;
        }

        public abstract void Calculate(); //forced to method 
        public virtual void Display()
        {
            Console.WriteLine("Simple Interest");
            Console.WriteLine();
            Console.WriteLine("Principle Amount : {0,10:0.00}", Principle);
            Console.WriteLine("Rate of Interest : {0,10:0.00}%", RateOfInterest);
            Console.WriteLine("No of years : {0,10:0.00}", NoOfYears);
            Console.WriteLine("Interest Amount : {0,10:0.00}", IntrestAmount);
            Console.WriteLine();
        }
    }
}
