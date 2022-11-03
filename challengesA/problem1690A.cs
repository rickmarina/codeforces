using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1690/A. Print a Pedestal (Codeforces logo?)
    public class problem1690A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int blocks = int.Parse(Console.ReadLine());

                int n = (blocks + 3) / 3;
                int rest = (blocks - ((n - 1) + (n) + (n - 2))) % 3;

                int a = n - 1, b = n, c = n - 2;

                if (rest == 2)
                {
                    a++;
                    b++;
                }
                else if (rest == 1)
                {
                    b++;
                }

                Console.WriteLine($"{a} {b} {c}");
            }

        }

    }

}