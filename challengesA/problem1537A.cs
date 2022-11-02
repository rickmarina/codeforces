using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1537A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                double n = double.Parse(Console.ReadLine());
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int sum = nums.Sum();
                if (sum / n == 1.0)
                {
                    Console.WriteLine("0");
                }
                else if (sum < 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine(Math.Max(1, sum - n));
                }



            }

        }

    }

}