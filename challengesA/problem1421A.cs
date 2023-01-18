using System.Linq;
using System;

namespace codeforces.challengesA;

//1421/A. XORwice
public class problem1421A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int a = nums[0], b = nums[1];
            int x = a & b;

            Console.WriteLine((a ^ x) + (b ^ x));
        }
    }
}

