using System.Linq;
using System; 

namespace codeforces.challengesA {

    //A. Phoenix and Balance
    public class problem1348A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {

                int n = int.Parse(Console.ReadLine());

                var test = Enumerable.Range(1,n).Select(x => Math.Pow(2,x)).ToArray();

                int rest = (n/2)-1;
                var suma1 = test[..rest].Sum() + test[n-1];
                var suma2 = test[rest..(n-1)].Sum();

                Console.WriteLine(Math.Abs(suma1-suma2));

            }
            
        }

    }

}