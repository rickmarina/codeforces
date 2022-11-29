using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1509/A. Average Height
    public class problem1509A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var evens = nums.Where(x => x % 2 == 0).ToArray();
                var odds = nums.Where(x => x % 2 == 1).ToArray();

                Console.WriteLine(string.Join(" ", odds.Concat(evens)));

            }


        }

    }

}