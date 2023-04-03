using System.Linq;
using System;

namespace codeforces.challengesD;

//1807/D. Odd Queries
public class problem1807D
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var nq = Console.ReadLine().Split(" ").Select(long.Parse).ToArray(); //length array and number of queries 

            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            //the trick is precalculate the partial sums 
            //in order we can evaluate the sum of a range inside the array
            var acc = new long[nq[0]];
            acc[0] = a[0];
            for (int i = 1; i < nq[0]; i++)
            {
                acc[i] = acc[i - 1] + a[i];
            }

            //then we can evaluate even /odd of what we sum, total, and what we delete
            for (int t = 0; t < nq[1]; t++)
            {
                var dat = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
                long l = dat[0], r = dat[1], k = dat[2];

                long sum = 0;
                if (l == 1)
                    sum = acc[r - 1];
                else
                    sum = acc[r - 1] - acc[l - 2];

                var add = (r - l + 1) * k;
                if (((acc[nq[0] - 1] + add - sum) & 1) == 1)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                /*
                var totalOdds = a.Where((x, i) => i < l - 1 || i > r - 1).Count(x=> (x&1)==1);
                var add = (r - l + 1) * k;
                if ((add & 1) ==1)
                    totalOdds++;

                if (totalOdds % 2 == 0)
                {
                    Console.WriteLine("NO");
                }
                else
                    Console.WriteLine("YES");
                */
            }
        }
    }
}




