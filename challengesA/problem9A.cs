using System.Linq;
using System; 

namespace codeforces.challengesA {

    //A. Die Roll
    public class problem9A {

        public static void solution() {

            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int num =  6-n.Max()+1, den = 6; 

            while ((num % 2 == 0 && den % 2 == 0) || (num % 3 == 0 && den % 3 == 0)) {
                if (num % 2 == 0) {
                    num = num / 2;
                    den = den / 2;
                } else if (num % 3 == 0) {
                    num = num / 3;
                    den = den / 3;
                }
            }

            System.Console.WriteLine($"{num}/{den}");
        }

    }

}