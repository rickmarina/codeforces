using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1487/A. Arena
    public class problem1487A
    {

        public static void solution()
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var robots = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                int min = robots.Min();

                int total = robots.Count(x => x > min);

                Console.WriteLine(total);


            }
        }

    }

}