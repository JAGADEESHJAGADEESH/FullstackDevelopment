using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Linq
{
    public static class IQueryableCollection
    {
        public static void GetEvenNumbers()
        {
            //Linq basic
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            evenNumbers.ToList().ForEach(Console.WriteLine);
        }
        public static void GetEvenNumbersWithLambda()
        {
            //Linq with Lambda
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            evenNumbers.ToList().ForEach(Console.WriteLine);
        }
    }
}
