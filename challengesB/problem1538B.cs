using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1538/B. Friends and Candies
    public class problem1538B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int sum = a.Sum();
                if (sum % n == 0)
                {
                    int k = a.Count(x => x > (sum / n));
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine("-1");
                }

            }

        }

    }

}