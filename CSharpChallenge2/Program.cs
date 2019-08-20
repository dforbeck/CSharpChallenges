using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenge2
{
    class AbsoluteDifference
    {
        public static void Main()
        {
            Console.WriteLine(Comp("Hello", "Good evening"));
            Console.WriteLine(Comp("incandescent", "organization"));
            Console.ReadLine();
        }

        public static bool Comp(string str1, string str2)
        {
            // code goes here
            int lstr1 = str1.Length;
            int lstr2 = str2.Length;

            if (lstr1 == lstr2)
            {
                return true;
            }
            else
                return false;
        }
    }
}
