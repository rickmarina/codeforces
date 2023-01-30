using System.Linq;
using System;

namespace codeforces.challengesA;

//1559/A. Mocha and Math
public class problem1559A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            var result = nums.Aggregate((x, y) => x & y);

            Console.WriteLine(result);

        }
    }
}

