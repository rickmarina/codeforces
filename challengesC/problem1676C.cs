using System.Linq;
using System;

namespace codeforces.challengesC
{

    //1676/C. Most Similar Words
    public class problem1676C
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int n = dat[0], m = dat[1];
                List<string> words = new();

                for (int i = 0; i < n; i++)
                    words.Add(Console.ReadLine());

                int res = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        int dif = diff(words[i], words[j], m, res);
                        res = Math.Min(res, dif);
                    }
                }

                Console.WriteLine(res);
            }

        }

        static int diff(string w1, string w2, int m, int best)
        {
            if (w1.Equals(w2))
                return 0;

            int total = 0;
            for (int i = 0; i < m; i++)
            {
                total += Math.Abs((int)w1[i] - (int)w2[i]);
                if (total > best)
                    break;
            }

            return total;
        }

    }

}