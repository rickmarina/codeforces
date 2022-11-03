using System.Linq;
using System; 

namespace codeforces.challengesA {

    //540/A. Combination Lock
    public class problem540A {

        public static void solution() {

            int disk = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Select(x=> int.Parse(x.ToString())).ToArray(); 
            var b = Console.ReadLine().Select(x=> int.Parse(x.ToString())).ToArray(); 

            var r = a.Select( (x, i) => Math.Min( Math.Abs(x-b[i]), 10 - Math.Abs(x-b[i]) ) ).Sum();

            Console.WriteLine(r);
            
        }

    }

}