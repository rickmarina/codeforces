using System.Linq;
using System;

namespace codeforces.challengesB;

//1535/B. Array Reodering
public class problem1535B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var even = nums.Where(x => x % 2 == 0).ToArray();
            var odd = nums.Where(x => x % 2 == 1).ToArray();

            int o = odd.Length;
            int e = n - o;
            int ans = e * o; //even*odd

            //results in odd array 
            for (int i = 0; i < o; i++)
            {
                for (int j = i + 1; j < o; j++)
                {
                    if (GCD(odd[i], 2 * odd[j]) > 1)
                        ans++;
                }
            }

            //add results in even array
            ans += (e * (e - 1) / 2);

            Console.WriteLine(ans);
        }
    }
    public static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}

