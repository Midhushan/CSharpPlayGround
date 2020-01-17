using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public class SimpleInterest : InterestBaseClass
    {
        public SimpleInterest():base(0,0,0)
        {

        }

        public SimpleInterest(double Principle, double RateOfInterest, int NoOfYears) : base(Principle, RateOfInterest, NoOfYears)
        {
        }

        public override void Calculate()
        {
            IntrestAmount = Principle * RateOfInterest * NoOfYears / 100;
        }
    }
}
