using System.Linq;
using System;

namespace codeforces.challengesA
{

    //214/A. System of Equations
    public class problem214A
    {

        public static void solution()
        {
            var nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int total = 0;
            for (int a = 0; a * a <= nm[0] && a <= nm[1]; a++)
            {
                int b = nm[0] - a * a;
                if (a + b * b == nm[1])
                {
                    total++;
                }
            }

            Console.WriteLine(total);

        }

    }

}