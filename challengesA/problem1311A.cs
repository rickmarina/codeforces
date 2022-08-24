using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1311/A. Add Odd or Subtract Even
    public class problem1311A {

        public static void solution() {

             int tc = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < tc; i++)
            {
                
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int diff = Math.Abs(nums[0] - nums[1]);
                int moves = 0; 

                if (nums[0] > nums[1]) { 
                    moves++;
                    if ((diff & 1) == 1) 
                        moves++;

                } else if (nums[0] < nums[1]) {
                    moves++;    
                    if ((diff & 1) == 0) 
                        moves++;
                } 

                Console.WriteLine($"{moves}");
            }
        }

    }

}