using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1660/B. Vlad and Candies
    public class problem1660B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var candies = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                if (n == 1 && candies[0] == 1)
                    Console.WriteLine("YES");
                else if (n == 1 && candies[0] > 1)
                    Console.WriteLine("NO");
                else
                {
                    candies = candies.OrderByDescending(x => x).ToList();
                    if (candies[0] - candies[1] <= 1)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }

            }

        }

    }

}