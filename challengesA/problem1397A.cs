using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1397/A. Juggling Letters
    public class problem1397A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                List<string> cads = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    cads.Add(Console.ReadLine());
                }

                var d = string.Join("", cads).GroupBy(g => g).Select(x => new { k = x.Key, v = x.Count() }).ToDictionary(d => d.k, d => d.v);

                bool equal = true;
                foreach (var item in d)
                {
                    if (item.Value % n != 0)
                    {
                        equal = false;
                        break;
                    }
                }

                Console.WriteLine(equal ? "YES" : "NO");
            }


        }

    }

}