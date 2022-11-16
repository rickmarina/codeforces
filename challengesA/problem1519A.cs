using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1519/A. Red and Blue Beans
    public class problem1519A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int r = nums[0], b = nums[1], d = nums[2];

                int dif = Math.Abs(r - b);
                double min = Math.Min(r, b);

                double calc = dif / min;
                if (calc <= d)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");



            }

        }

    }

}