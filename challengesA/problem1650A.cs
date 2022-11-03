using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1650/A. Deletions of Two Adjacent Letters
    public class problem1650A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var letters = Console.ReadLine();
                string c = Console.ReadLine();

                var r = letters.Select((x, y) => (x.ToString() == c) ? y : -1).Where(x => x != -1);

                if (r.Any(x => (x % 2) == 0 && (letters.Length - 1 - x) % 2 == 0))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }


            }

        }

    }

}