using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1283/A. Minutes Before the New Year
    public class problem1283A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < tc; i++)
            {
                var n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
                int diff = 60-n[1] + (24-n[0]-1)*60;

                Console.WriteLine(diff);
            }   
            
        }

    }

}