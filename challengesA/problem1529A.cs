using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1529/A. Eshag Loves Big Arrays
    public class problem1529A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var serie = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int min = serie.Min();

                int total = serie.Count(x => x > min);

                Console.WriteLine(total);

            }

        }

    }

}