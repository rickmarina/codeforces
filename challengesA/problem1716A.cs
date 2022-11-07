using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1716/A. 2-3 Moves
    public class problem1716A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int total = 0;

                if (n == 1)
                    total = 2;
                else if (n % 3 == 0)
                    total = n / 3;
                else if (n % 2 == 0)
                {
                    total = n / 3 + 1;
                }
                else
                {
                    total = (n / 3) - 1 + 2;
                }

                Console.WriteLine(total);
            }

        }

    }

}