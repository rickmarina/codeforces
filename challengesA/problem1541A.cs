using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1541/A. Pretty Permutations
    public class problem1541A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                var a = Enumerable.Range(1, n).ToArray();

                for (int i = 0; i < n - 1; i += 2)
                {
                    int aux = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = aux;
                }

                if (n % 2 == 1)
                {
                    int aux = a[n - 2];
                    a[n - 2] = a[n - 1];
                    a[n - 1] = aux;
                }

                Console.WriteLine(string.Join(" ", a));
            }

        }

    }

}