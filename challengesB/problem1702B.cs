using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1702/B. Polycarp Writes a String from Memory
    public class problem1702B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var word = Console.ReadLine();

                HashSet<char> letters = new();
                int total = 0;
                foreach (var c in word)
                {
                    letters.Add(c);
                    if (letters.Count == 4)
                    {
                        //Console.WriteLine(string.Join(" ",letters.ToArray()));
                        total++;
                        letters.Clear();
                        letters.Add(c);
                    }
                }

                if (letters.Count > 0)
                    total++;

                Console.WriteLine(total);
            }

        }

    }

}