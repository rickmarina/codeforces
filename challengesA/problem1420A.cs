using System.Linq;
using System;

namespace codeforces.challengesA;

//1420/A. Cubes Sorting
public class problem1420A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        // max moves = [n*(n-1) /2] -1
        // if all numbers are decreasing order we need [n*(n-1) /2] moves to sort, so in this case the result will be
        // in all rest cases we will be able to sort 

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            bool canSort = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] <= nums[i + 1])
                {
                    canSort = true;
                    break;
                }
            }

            Console.WriteLine(canSort ? "YES" : "NO");
        }
    }
}

