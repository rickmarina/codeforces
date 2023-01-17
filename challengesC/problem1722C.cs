using System.Linq;
using System;

namespace codeforces.challengesC;

//1722/C. Word Game
public class problem1722C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int nwords = int.Parse(Console.ReadLine());
            var line1 = Console.ReadLine().Split(" ");
            var line2 = Console.ReadLine().Split(" ");
            var line3 = Console.ReadLine().Split(" ");

            Dictionary<string, int> wordRepeated = new();
            HashSet<string> wordSet = new();

            foreach (var w in line1.Concat(line2).Concat(line3))
            {
                if (wordSet.Add(w))
                {
                    wordRepeated.Add(w, 1);
                }
                else
                {
                    wordRepeated[w]++;
                }
            }

            //Score
            Console.WriteLine($"{scores(line1, wordRepeated)} {scores(line2, wordRepeated)} {scores(line3, wordRepeated)}");

        }
    }
    static int scores(IEnumerable<string> line, Dictionary<string, int> repeated)
    {
        int score = 0;
        foreach (var w in line)
        {

            score += repeated[w] switch
            {
                1 => 3,
                2 => 1,
                3 => 0,
                _ => 0
            };
        }
        return score;
    }
}

