using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1632A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var s = Console.ReadLine();

                int t1 = s.Count(x => x == '1');
                int t0 = s.Count(x => x == '0');

                if (n > 1 && (t1 == 0 || t0 == 0))
                {
                    Console.WriteLine("NO");
                }
                else if ((n >= 3) || (t1 > 1 && t0 > 1))
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }

        }

    }

}