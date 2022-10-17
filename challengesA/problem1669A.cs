using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1669/A. Division?
    public class problem1669A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                int r = int.Parse(Console.ReadLine());

                var d = r switch 
                {
                    >= 1900 => 1,
                    >= 1600 => 2,
                    >= 1400 => 3,
                    _ => 4
                };

                Console.WriteLine($"Division {d}");
                
            }
            
        }

    }

}