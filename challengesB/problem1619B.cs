using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1619/B. Squares and Cubes
    public class problem1619B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                HashSet<long> r = new HashSet<long>();

                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    r.Add(i * i);
                    if (i * i * i <= n)
                    {
                        r.Add(i * i * i);
                    }
                }


                Console.WriteLine(r.Count + 1);

            }

        }

    }

}