using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1729/A. Two Elevators
    public class problem1729A
    {

        public static void solution()
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var abc = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int time1 = Math.Abs(abc[0] - 1);
                int time2 = Math.Abs(abc[1] - abc[2]) + Math.Abs(abc[2] - 1);

                if (time1 < time2)
                    Console.WriteLine("1");
                else if (time1 > time2)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }

    }

}