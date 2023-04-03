using System.Linq;
using System;

namespace codeforces.challengesA;

//1679/A. AvtoBus
public class problem1679A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            if ((n & 1) == 1 || n <= 3)
                Console.WriteLine("-1");
            else
            {
                n = n / 2;
                long t1 = n / 3;
                if (n % 3 == 2 || n % 3 == 1)
                {
                    t1++;
                }
                long t2 = n / 2;
                Console.WriteLine(Math.Min(t1, t2) + " " + Math.Max(t1, t2));

            }
        }
    }
}




