using System.Linq;
using System; 

namespace codeforces.challengesC {

    //1714/C. Minimum Varied Number
    public class problem1714C {

        public static void solution() {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var s = int.Parse(Console.ReadLine());

                if (s < 10) {
                    Console.WriteLine(s);
                } else {
                    Stack<int> res = new(); 
                    int num = 9;
                    int sum = 0;
                    while (sum != s) {
                        sum += num;
                        res.Push(num);
                        if (s - sum < num) 
                            num = (s-sum);
                        else 
                            num--;
                    }

                    foreach(var i in res) {
                        Console.Write(i);
                    }
                    Console.WriteLine("");
                    
                    
                }

            }
        }

    }

}