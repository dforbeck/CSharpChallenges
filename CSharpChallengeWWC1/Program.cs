using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallengeWWC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(53));
            Console.WriteLine(test(30));
            Console.WriteLine(test(51));
            Console.ReadLine();
        }
        public static int test(int n)
        {
            // code goes here
            int absDiff = Math.Abs(n - 51);
            int triple = 3 * absDiff;

            if (n > 51)
            {
                return triple;
            }
            else
                return absDiff;

        }
    }
}
