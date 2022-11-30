using System.Linq;
using System;

namespace codeforces.challengesA
{

    //255/A. Greg's Workout
    public class problem255A
    {

        public static void solution()
        {
            int n = int.Parse(Console.ReadLine());

            var ex = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int totalChest = ex.Where((x, i) => (i % 3) == 0).Sum();
            int totalBiceps = ex.Where((x, i) => (i % 3) == 1).Sum();
            int totalBack = ex.Where((x, i) => (i % 3) == 2).Sum();

            if (totalChest >= totalBiceps && totalChest >= totalBack)
            {
                Console.WriteLine("chest");
            }
            else if (totalBiceps > totalChest && totalBiceps > totalBack)
            {
                Console.WriteLine("biceps");
            }
            else
            {
                Console.WriteLine("back");
            }

        }

    }

}