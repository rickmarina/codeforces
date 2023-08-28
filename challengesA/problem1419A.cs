using System.Linq;
using System;

namespace codeforces.challengesA;

//1419/A. Digit Game
public class problem1419A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine()); //digits 
            var d = Console.ReadLine();

            //Raze (1) marks odd positions - win if odd left
            //Breach (2) marks even positions - win if even left

            int raze_even = 0, raze_odd = 0;
            int breach_even = 0, breack_odd = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if ((int.Parse(d[i].ToString()) % 2) == 0)
                        raze_even++;
                    else
                        raze_odd++;
                }
                else
                {
                    if ((int.Parse(d[i].ToString()) % 2) == 0)
                        breach_even++;
                    else
                        breack_odd++;
                }
            }
            int result = 0;
            if (n % 2 == 0)
            {
                result = (breach_even > 0) ? 2 : 1;
            }
            else
            {
                result = (raze_odd > 0) ? 1 : 2;
            }


            Console.WriteLine($"{result}");

        }
    }
}


