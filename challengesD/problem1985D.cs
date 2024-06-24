using System.Linq;
using System;

namespace codeforces.challengesD;

//D. Manhattan Circle
public class Problem1985D
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int n, int m) = (input[0], input[1]);

            double y = 0, x = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int count = line.Count(x => x == '#');
                if (count > max)
                {
                    y = i + 1;
                    x = line.IndexOf('#') + Math.Ceiling(count / 2.0);
                    max = count;
                }
            }

            System.Console.WriteLine($"{y} {x}");
        }
    }
}


