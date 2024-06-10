using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Sending Messages
public class Problem1921C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long n, long f, long a, long b) = (input[0], input[1], input[2], input[3]);

            // n # messages
            // f initial phone charge
            // a consumption per unit time 
            // b consumption turn off|on

            var moments = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //cost between moments vs b
            long initialCost = 0;
            long totalCost = 0;
            for (int i = 0; i < n; i++)
            {
                totalCost += Math.Min((moments[i] - initialCost) * a, b);
                initialCost = moments[i];

                if (totalCost >= f)
                    break;
            }

            if (totalCost >= f)
                System.Console.WriteLine("NO");
            else
                System.Console.WriteLine("YES");

        }
    }
}


