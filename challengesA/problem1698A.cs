using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1698/A. XOR Mixup
    public class problem1698A
    {

        public static void solution()
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int r = -1;
                for (int i = 0; i < n; i++)
                {
                    //Console.Write(string.Join(",",data.Where( (x,p) => p != i)));
                    r = data.Where((x, p) => p != i).Aggregate((x, y) => x ^ y);
                    //Console.WriteLine(" r: "+r);
                    if (r == data[i])
                    {
                        break;
                    }
                }

                Console.WriteLine(r);


            }
        }

    }

}