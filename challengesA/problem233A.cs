using System.Linq;
using System;

namespace codeforces.challengesA
{

    //233/A. Perfect Permutation
    public class problem233A
    {

        public static void solution()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("-1");
                return;
            }

            Console.Write("2 1");
            for (int i = 3; i < n; i += 2)
            {
                Console.Write($" {i + 1} {i}");
            }
            Console.WriteLine(Environment.NewLine);

        }

    }

}