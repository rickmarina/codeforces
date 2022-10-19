using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1385/A. Three Pairwise Maximums
    public class problem1385A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var max = nums.Max();
                var totalMax = nums.Count(x => x == max);

                if (totalMax == 3)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine($"{max} {max} {max}");
                }
                else if (totalMax < 2)
                    Console.WriteLine("NO");
                else
                {
                    var third = nums.First(x => x != max);
                    Console.WriteLine("YES");
                    Console.WriteLine($"{max} {third} 1");
                }
            }
            
        }

    }

}