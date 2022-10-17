using System.Linq;
using System; 

namespace codeforces.challengesB {

    ///1385/B. Restore the Permutation by Merger
    public class problem1385B {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                int order = int.Parse(Console.ReadLine());
                List<int> permutation = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                List<int> original = new List<int>();

                for (int p = 0; p < permutation.Count() && original.Count() < order; p++)
                {
                    if (!original.Contains(permutation[p])) 
                        original.Add(permutation[p]);
                }

                Console.WriteLine($"{string.Join(" ",original)}");

            }

            
        }

    }

}