using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXNEtExamples1
{
    class Corecursion
    {
        private static IEnumerable<T> lovely<T>(T seed, Func<T, T> accumulator)
        {
            var nextValue = seed;
            while (true)
            {
                yield return nextValue;
                nextValue = accumulator(nextValue);
            }
        }
        static void Main(string[] args)
        {
            var naturalNumbers = lovely(1, i => i + 1);
            Console.WriteLine("1st 10 Natural numbers");
            foreach (var naturalNumber in naturalNumbers.Take(10))
            {
                Console.WriteLine(naturalNumber);
            }
        }
    }
}
