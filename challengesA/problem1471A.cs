using System.Linq;
using System;

namespace codeforces.challengesA;

//1471/A. Strange Partition
public class problem1471A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray();
            decimal n = dat[0], div = dat[1];

            var nums = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray();
            decimal max = nums.Select(x => Math.Ceiling(x / div)).Sum();
            decimal min = Math.Ceiling(nums.Sum() / div);

            Console.WriteLine($"{min} {max}");


        }
    }
}

