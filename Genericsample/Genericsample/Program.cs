using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsample
{
    class myclass<T>
    {
        public bool compare(T a, T b)
            {
            if (a.Equals(b))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass<int> value = new myclass<int>();
            bool result = value.compare(10, 5);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
