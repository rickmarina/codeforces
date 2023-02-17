using System.Linq;
using System;

namespace codeforces.challengesA;

//1525/B. Permutation Sort
public class problem1525B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int pmax = Array.IndexOf(nums, nums.Max());
            int pmin = Array.IndexOf(nums, nums.Min());

            bool sorted = isSorted(nums);

            int total = 0;
            if (pmax != n - 1)
                total++;
            if (pmin != 0)
                total++;
            if (pmin == n - 1 && pmax == 0)
                total++;
            if (total == 0 && !sorted)
                total++;

            Console.WriteLine(total);

        }
    }

    static bool isSorted(int[] serie)
    {
        for (int i = 0; i < serie.Length - 1; i++)
        {
            if (serie[i] > serie[i + 1])
                return false;
        }
        return true;
    }
}

