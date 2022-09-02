using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1692/A. Marathon
    public class problem1692A {

        public static void solution() {

             int tc = int.Parse(Console.ReadLine());

           for (int i = 0; i < tc; i++)
           {
                var nums = Console.ReadLine().Split(" ").Select(int.Parse);
                Console.WriteLine(nums.Where(x=> x> nums.First()).Count());
           }
        }

    }

}