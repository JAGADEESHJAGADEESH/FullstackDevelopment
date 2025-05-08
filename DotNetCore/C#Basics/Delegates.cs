using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    public class Delegates
    {

        public Delegates()
        {
            
        }

        public delegate int AddNumber(int a, int b);
        public delegate int SubtractNumber(int a, int b);

        // method "sum"
        public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} =" +"{0}", sum);
            return sum;
        }

        // method "subtract"
        public int Subtract(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} =" + "{0}", sub);
            return sub;
        }

    }
}
