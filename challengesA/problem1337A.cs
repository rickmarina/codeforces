using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1337/A. Ichihime and Triangle
    public class problem1337A {

        public static void solution() {

             int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 

                Console.WriteLine($"{nums[1]} {nums[2]} {nums[2]}");
            }
          
        }

    }

}