using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance
{
    public class MySimpleIntrest
    {
        public double PrincipleAmount { get; set; }
        public double RateOfInterest { get; set; }
        public int NoOfYears { get; set; }
        public double IntrestAmount { get; set; }

        //Overloaded Constructor
        public MySimpleIntrest(double PrincipleAmount, double RateOfInterest, int NoOfYears)
        {
            this.PrincipleAmount = PrincipleAmount;
            this.RateOfInterest = RateOfInterest;
            this.NoOfYears = NoOfYears;


        }

        ~MySimpleIntrest()
        {
            //PrincipleAmount = null;
            //RateOfInterest = null;
            //NoOfYears = null;
        }

        //static constructor
        static MySimpleIntrest()
        {
            Console.WriteLine("This Excutes only one time");
        }

        public MySimpleIntrest()
        {
        }

        public void Calculate() //Method
        {
            IntrestAmount = PrincipleAmount * RateOfInterest * NoOfYears / 100;

        }

        public void Display() //Method
        {
            Console.WriteLine("Simple Interest");
            Console.WriteLine();
            Console.WriteLine("Principle Amount : {0,10:0.00}", PrincipleAmount);
            Console.WriteLine("Rate of Interest : {0,10:0.00}%", RateOfInterest);
            Console.WriteLine("No of years : {0,10:0.00}", NoOfYears);
            Console.WriteLine("Interest Amount : {0,10:0.00}", IntrestAmount);
            Console.WriteLine();
        }
    }
}
