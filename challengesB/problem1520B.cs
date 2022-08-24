using System.Linq;
using System; 

namespace codeforces.challengesB {

    //1520/B Ordinary Numbers
    public class problem1520B {

        public static void solution() {

            int tc = int.Parse(Console.ReadLine()); 
            //int tc = 1;

            for (int c = 0; c < tc; c++) {
                int n = Convert.ToInt32(Console.ReadLine());

                int ordinaries = 9*(n.ToString().Length-1) + (n / int.Parse(new string('1', n.ToString().Length)));

                Console.WriteLine($"{ordinaries}");
            }
        }

    }

}