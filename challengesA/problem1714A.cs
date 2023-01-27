using System.Linq;
using System;

namespace codeforces.challengesA;

//1714/A. Everyone Loves to Sleep
public class problem1714A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], H = input[1], M = input[2];

            int difMin = int.MaxValue;
            var alarms = Enumerable.Range(0, n).Select(x => Console.ReadLine().Split(" ").Select(int.Parse).ToArray()).ToArray();

            for (int i = 0; i < n; i++)
            {
                int ah = alarms[i][0], am = alarms[i][1];

                int ts1 = M + H * 60;
                int ts2 = am + ah * 60;

                if (ts1 == ts2)
                {
                    difMin = 0;
                    break;
                }
                else
                {
                    int difM = 0;
                    if (ts2 < ts1)
                    {
                        //minutos hasta 24h 
                        int min24 = (24 * 60) - ts1;
                        difM = ts2 + min24;
                    }
                    else
                    {
                        difM = ts2 - ts1;
                    }

                    difMin = Math.Min(difMin, difM);
                }
            }

            int h = difMin / 60;
            int m = difMin - (h * 60);

            Console.WriteLine($"{h} {m}");

        }
    }
}

