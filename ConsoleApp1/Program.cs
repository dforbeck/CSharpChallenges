using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WeightedAverage
    {
        public static double Mean(IList<int> numbers, IList<int> weights)
        {
            var total = 0;
            var totalWeights = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                total += numbers[i] * weights[i];
                totalWeights += weights[i];
            }

            return total / totalWeights;
        }

        static void Main(string[] args)
        {
            int[] values = new int[] { 3, 6, 8};
            int[] weights = new int[] { 4, 2 };

            Console.WriteLine(WeightedAverage.Mean(values, weights));


        }
    }
}
