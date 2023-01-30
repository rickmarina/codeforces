using System.Linq;
using System;

namespace codeforces.challengesB;

//1206/B. Make Product Equal One
public class problem1206B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

        long totalNeg = nums.Count(x => x < 0);
        long totalZero = nums.Count(x => x == 0);

        long coins = 0;
        //totalNeg and totalZero can be increased inside this loop for increase performance
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0)
            {
                coins++;
            }
            else if (nums[i] < 0)
            {
                coins += -nums[i] - 1;
            }
            else
            {
                coins += nums[i] - 1;
            }
        }

        if ((totalNeg % 2 != 0) & (totalZero == 0))
        {
            coins += 2;
        }

        Console.WriteLine(Math.Abs(coins));
    }
}

