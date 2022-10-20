using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1325/A. EhAb AnD gCd
    //GCD(a,b) + LCM(a,b) == x;
    public class problem1325A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                int a = 1, b = x - 1;
                Console.WriteLine($"{a} {b}");
            }

        }

    }

}