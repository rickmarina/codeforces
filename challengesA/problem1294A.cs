using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1294/A. Collecting Coins
    public class problem1294A {

        public static void solution() {

            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                var coins = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int max = coins[..^1].Max();
                int toequal = max - coins[0] + max - coins[1] + max - coins[2];

                int resto = coins[^1] - toequal;
                if (resto >= 0 && (resto % 3) == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

    }

}