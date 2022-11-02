using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1593/A. Elections
    public class problem1593A {

        public static void solution() {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var abc = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                
                int max = abc.Max();
                int tot = abc.Count(x=> x== max); 

                var r = new List<int>(); 
                if (tot > 1)
                    r = abc.Select(x=> max+1 - x ).ToList();
                else 
                    r = abc.Select(x=> x == max && max != 0 ? 0 : max+1 - x ).ToList();


                Console.WriteLine(string.Join(" ", r));

            }
        }

    }

}