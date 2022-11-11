using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1631/A. Min Max Swap
    public class problem1631A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int i = 0; i < n; i++)
                {
                    if (a[i] < b[i])
                    {
                        int aux = a[i];
                        a[i] = b[i];
                        b[i] = aux;
                    }
                }

                int maxA = a.Max();
                int maxB = b.Max();
                int r = maxA * maxB;

                Console.WriteLine(r);

            }

        }

    }

}