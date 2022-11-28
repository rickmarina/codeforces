using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1741/A. Compare T-Shirt Sizes
    public class problem1741A
    {

        public static void solution()
        {
            var sizes = new Dictionary<string, int>() {
                {"S", -10},
                {"M", 0},
                {"L", 10}
            };

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var shirts = Console.ReadLine().Split(" ").ToArray();

                var values = shirts.Select(x => Math.Max(x.Count(c => c == 'X') * 2, 1) * sizes[x.Replace("X", "")]).ToArray();

                if (values[0] == values[1])
                    Console.WriteLine("=");
                else if (values[0] > values[1])
                    Console.WriteLine(">");
                else
                    Console.WriteLine("<");

            }

        }

    }

}