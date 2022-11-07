using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1549/A. Gregor and Cryptography
    public class problem1549A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int p = int.Parse(Console.ReadLine());

                if ((p & 1) == 1)
                    Console.WriteLine($"2 {p - 1}");
                else
                    Console.WriteLine($"2 {p}");

            }

        }

    }

}