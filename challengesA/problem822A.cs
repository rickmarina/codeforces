using System.Linq;
using System;

namespace codeforces.challengesA
{

    //822/A. I'm bored with life
    public class problem822A
    {

        public static void solution()
        {
            var ab = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int res = 1;
            for (int i = 2; i <= Math.Min(ab[0], ab[1]); i++)
            {
                res *= i;
            }

            Console.WriteLine(res);

        }

    }

}