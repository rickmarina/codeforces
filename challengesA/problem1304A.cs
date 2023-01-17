using System.Linq;
using System;

namespace codeforces.challengesA;

//1304/A. Two Rabbits
public class problem1304A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x = nums[0], y = nums[1], a = nums[2], b = nums[3];

            if ((y - x) % (a + b) == 0)
            {
                Console.WriteLine((y - x) / (a + b));
            }
            else
                Console.WriteLine("-1");

        }
    }
}

