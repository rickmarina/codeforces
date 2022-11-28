using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1760/B. Atilla's Favorite Problem
    public class problem1760B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var s = Console.ReadLine();
                int max = s.Select(x => (int)x).Max();

                Console.WriteLine(max - 96);


            }

        }

    }

}