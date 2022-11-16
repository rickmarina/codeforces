using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1553/A. Digits Sum
    public class problem1553A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int r = n % 10;

                if (r < 9)
                    Console.WriteLine(n / 10);
                else
                    Console.WriteLine((n / 10) + 1);
            }

        }

    }

}