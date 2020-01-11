using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqEx
{
    class student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student[] Details =
            {
                new student() {name="abi", age=1, Address="jaffna"},
                new student() {name="raja", age=2, Address="kilinochi" },
                new student() {name="roja", age=3, Address="chunnakam" },
                new student() {name="raja", age=4, Address="mallakam" },
                new student() { name="bala", age=5,Address="mullaitivu" }
            };


            var child = from a in Details
                        where a.name == "raja" && a.age == 2
                        select Details;

            
             
            foreach(var a in child)
            {
                Console.WriteLine("student name: {0} - student age: {1} - student Address:{2}",a.name,a.age,a.Address);

                
    
            }
            Console.ReadKey();
        }
    }
}
