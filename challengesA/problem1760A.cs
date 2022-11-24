using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1760/A. Medium Number
    public class problem1760A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int r = n.Where(x => x != n.Max() && x != n.Min()).FirstOrDefault();

                Console.WriteLine(r);
            }

        }

    }

}