using System.Linq;
using System;

namespace codeforces.challengesA;

//1272/A. Three Friends
public class problem1272A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        int num = 0;
        while (tc-- > 0)
        {
            num++;
            var dat = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            long avg = (long)Math.Round(dat.Average());
            //   Console.WriteLine($"avg: {avg}");

            for (int i = 0; i < dat.Length; i++)
            {
                if (dat[i] < avg) dat[i]++;
                else if (dat[i] > avg) dat[i]--;
            }
            //   Console.WriteLine(string.Join(" ",dat));

            var tot = TotalPairwise(dat[0], dat[1], dat[2]);
            Console.WriteLine(tot);
        }
    }
    // this formula can be simplified to 2a - 2c -> 2(a-c) -> 2(max - min)
    // then we can order the array then apply the formula before and substract two moves finally limit the answer to 0
    static long TotalPairwise(long a, long b, long c) => Math.Abs(a - b) + Math.Abs(a - c) + Math.Abs(b - c);
}




