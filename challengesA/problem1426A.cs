using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1426/A. Floor Number
    public class problem1426A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                var nums = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray<Decimal>();

                if (nums[0]-2 <= 0)
                Console.WriteLine("1");
                else { 
                var r = Math.Ceiling((nums[0]-2) / nums[1]) +1; 
                Console.WriteLine(r);
                }
            }
            
        }

    }

}