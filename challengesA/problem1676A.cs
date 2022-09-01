using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1676/A. Lucky?
    public class problem1676A {

        public static void solution() {

            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                
                string n = Console.ReadLine();

                var sum1 = n[0..3].Select(x=> int.Parse(x.ToString())).Sum();
                var sum2 = n[3..6].Select(x=> int.Parse(x.ToString())).Sum();

                Console.WriteLine(sum1 == sum2 ? "YES" : "NO");
            }
        }

    }

}