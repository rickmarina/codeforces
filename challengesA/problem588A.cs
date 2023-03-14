using System.Linq;
using System;

namespace codeforces.challengesA;

//588/A. Duff and Meat
public class problem588A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        int bestprice = int.MaxValue;
        int minMoney = 0;
        while (n-- > 0)
        {
            var ap = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bestprice = Math.Min(bestprice, ap[1]);
            minMoney += bestprice * ap[0];
        }
        Console.WriteLine($"{minMoney}");
    }
}

