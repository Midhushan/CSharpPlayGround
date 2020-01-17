using CSharpAdvance.Inheritance;
using System;

namespace CSharpAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            SimpleInterest oSI = new SimpleInterest(5000, 15.5, 3);
            oSI.Calculate();
            oSI.Display();
            oSI = null;

            CompoundInterest oCI = new CompoundInterest(5000, 15.5, 3, 4);
            oCI.Calculate();
            oCI.Display();
          

            oCI.DeductServiceCharge(250);
            oCI.Calculate();
            oCI.Display();
            oCI = null;



            Console.WriteLine("Press a key...");
        }
        //static void Main(string[] args)
        //{

        //    MySimpleIntrest oSI = new MySimpleIntrest(5000,24.5,3);
        //    //oSI.PrincipleAmount = 4000;
        //    //oSI.RateOfInterest = 10.5;
        //    //oSI.NoOfYears = 4;
        //    oSI.Calculate();
        //    oSI.Display();
        //    oSI = null;

        //    //for static construtor

        //    MySimpleIntrest oSI2 = new MySimpleIntrest(10000, 24.5, 3);
        //    oSI2.Calculate();
        //    oSI2.Display();
        //    oSI2 = null;
        //}

    }    
}
