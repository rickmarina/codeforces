using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1709/A. Three Doors
    public class problem1709A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int mykey = int.Parse(Console.ReadLine());

                var doors = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (doors[mykey - 1] != 0 && doors[doors[mykey - 1] - 1] != 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }

        }

    }

}