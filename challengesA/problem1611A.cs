using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1611/A. Make Even
    public class problem1611A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int total = 0;

                int n = int.Parse(Console.ReadLine());

                bool anyEven = n.ToString().Any(x => int.Parse(x.ToString()) % 2 == 0);
                if (!anyEven)
                    total = -1;
                else
                {
                    int last = int.Parse(n.ToString().Last().ToString());
                    int first = int.Parse(n.ToString().Substring(0, 1));

                    if (last % 2 == 0)
                        total = 0;
                    else if (first % 2 == 0)
                        total = 1;
                    else
                        total = 2;

                }

                Console.WriteLine(total);
            }

        }

    }

}