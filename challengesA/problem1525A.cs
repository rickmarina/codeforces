using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1525/A. Potion-making
    public class problem1525A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int gcd = GCD(100, n);
                Console.WriteLine(100 / gcd);
            }


        }
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

    }

}