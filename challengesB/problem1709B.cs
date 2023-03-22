using System.Linq;
using System;

namespace codeforces.challengesB;

//1709/B. Also Try Minecraft
public class problem1709B
{

    public static void solution()
    {
        var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int n = nums[0]; // # columns 
        int m = nums[1]; // # quests 

        var map = Console.ReadLine().Split(" ").Select(long.Parse).ToArray(); //height columns 

        // DP: precalculate the accumulated fall
        // then use this data to substract end - start 
        long[] asc = new long[n];
        long[] desc = new long[n];
        for (int i = 1; i < n; i++)
        {
            asc[i] = asc[i - 1] + (map[i - 1] > map[i] ? map[i - 1] - map[i] : 0);
        }

        for (int i = n - 2; i >= 0; i--)
        {
            desc[i] = desc[i + 1] + (map[i + 1] > map[i] ? map[i + 1] - map[i] : 0);
        }

        while (m-- > 0)
        {
            var quest = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); // quest: start and end

            int start = quest[0] - 1, end = quest[1] - 1;
            long damage = 0;

            if (start < end)
                damage = asc[end] - asc[start];
            else
                damage = desc[end] - desc[start];

            Console.WriteLine(damage);
        }
    }
}


