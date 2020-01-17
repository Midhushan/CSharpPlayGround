using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public partial class CompoundInterest
    {
        public void DeductServiceCharge(double ServiceCharge)
        {
            Principle -= ServiceCharge;
        }
    }
}
