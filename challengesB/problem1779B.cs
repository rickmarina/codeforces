using System.Linq;
using System;

namespace codeforces.challengesB;

//1779/B. MKnez's ConstructiveForces Task
public class problem1779B
{

    public static void solution()
    {
        //More formally, si≠0 must hold for each 1≤i≤n . Moreover, it must hold that s1+s2+⋯+sn=si+si+1 for each 1≤i<n
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 3)
                Console.WriteLine("NO");
            else
            {
                int a = 0, b = 0;
                if (n % 2 == 0)
                {
                    a = 1;
                    b = -1;
                }
                else
                {
                    a = (n / 2) - 1;
                    b = -(n / 2);
                }

                Console.WriteLine("YES");
                var serie = Enumerable.Range(0, n).Select(x => x % 2 == 0 ? a : b);
                Console.WriteLine(string.Join(" ", serie));
            }

        }
    }
}

