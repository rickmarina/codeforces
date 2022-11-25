using System.Linq;
using System;

namespace codeforces.challengesC
{

    //1560/C. Infinity Table
    public class problem1560C
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int k = int.Parse(Console.ReadLine());

                int i = 1;
                int j = 1;
                int start = 1;
                while (start + i <= k)
                {
                    start += i;
                    i += 2;
                    j++;
                    //Console.WriteLine("start : "+start+ " j: "+j + " elements: "+i);
                }
                int row = 0, col = 0;
                if (k - start >= j)
                    row = j;
                else
                    row = k - start + 1;

                col = Math.Min((start + i) - k, j);

                Console.WriteLine($"{row} {col}");
            }

        }

    }

}