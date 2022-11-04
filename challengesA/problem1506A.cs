using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1506/A. Strange Table
    public class problem1506A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var dat = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray();

                int f = (int)(dat[2] % dat[0]);
                if (f == 0) f = (int)dat[0];
                int c = (int)Math.Ceiling(dat[2] / dat[0]);

                //Console.WriteLine($"{f} {c}");

                decimal r = (dat[1] * f) - dat[1] + c;

                Console.WriteLine(r);
            }

        }

    }

}