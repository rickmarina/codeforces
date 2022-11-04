using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1490/A. Dense Array
    public class problem1490A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var a = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

                int total = 0;
                int i = 0;
                while (i < a.Count() - 1)
                {
                    if (Math.Max(a[i], a[i + 1]) / Math.Min(a[i], a[i + 1]) > 2.0)
                    {
                        total++;
                        if (a[i] < a[i + 1])
                            a[i] = a[i] * 2;
                        else
                            a[i] = Math.Ceiling(a[i] / 2);
                    }
                    else
                    {
                        i++;
                    }
                }

                Console.WriteLine($"{total}");

            }

        }

    }

}