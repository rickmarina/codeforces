using System.Linq;
using System;

namespace codeforces.challengesB;

//1543/B. Customising the Track
public class problem1543B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            var sum = cars.Sum();
            var rest = (sum % n);

            var ans = (n - rest) * rest;

            Console.WriteLine(ans);
        }
    }
    static long inconvenience(long[] cars)
    {
        long result = 0;

        for (int i = 0; i < cars.Length; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                result += Math.Abs(cars[i] - cars[j]);
            }
        }

        return result;

    }
}

