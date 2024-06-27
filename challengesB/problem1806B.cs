using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Mex Master
public class Problem1806B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int z = v.Count(x => x == 0);
            int nz = v.Length - z;
            int max = v.Max();

            // System.Console.WriteLine($"0s: {z} nZ: {nz} max: {max}");

            if (z <= nz + 1)
            {
                System.Console.WriteLine("0");
            }
            else
            {
                if (max == 1)
                {
                    System.Console.WriteLine("2");
                }
                else
                {
                    System.Console.WriteLine("1");
                }

            }
        }
    }
}


