using System.Linq;
using System; 

namespace codeforces.challengesA {

    //707A A. Brain's Photos
    public class problem707A {

        public static void solution() {
            string[] colors = new[] { "C", "M", "Y" };

            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
            int n = input[0], m = input[1];

            var imgData = Enumerable.Range(0, n).Select(x=> Console.ReadLine().Split(" ").ToList());

            var colored = imgData.Any( x=> x.Any( x=> colors.Contains(x)));

            Console.WriteLine(colored ? "#Color" : "#Black&White");
        }

    }

}