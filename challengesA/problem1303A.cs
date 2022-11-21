using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1303A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var s = Console.ReadLine();

                int total = 0;
                bool f1 = false;
                int li = s.LastIndexOf('1');
                if (li > -1)
                {
                    foreach (var c in s.Substring(0, li))
                    {
                        if (c == '1' && !f1)
                            f1 = true;

                        if (c == '0' && f1)
                            total++;
                    }
                }

                Console.WriteLine($"{total}");

            }

        }

    }

}