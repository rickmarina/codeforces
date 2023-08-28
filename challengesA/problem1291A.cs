using System.Linq;
using System;

namespace codeforces.challengesA;

//1291/A. Even But Not Even
public class problem1291A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var num = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();

            string result = "";

            long[] sum = new long[n];
            sum[0] = num[0];
            for (int i = 1; i < n; i++)
            {
                sum[i] = sum[i - 1] + num[i];
                //Console.WriteLine($"sum : {sum[i]}");
                if (sum[i] % 2 == 0 && (num[i] % 2) != 0)
                {
                    result = string.Join("", num[0..(i + 1)]);
                }
            }

            if (result.Length > 0)
                Console.WriteLine($"{result}");
            else
                Console.WriteLine("-1");

        }
    }
}


