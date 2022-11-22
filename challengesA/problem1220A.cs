using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1220/A. Cards
    public class problem1220A
    {

        public static void solution()
        {

            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var groups = input.GroupBy(g => g).Select(x => new { k = x.Key, v = x.Count() });

            int ones = groups.Where(x => x.k == 'n').Select(x => x.v).FirstOrDefault();
            int zeroes = groups.Where(x => x.k == 'z').Select(x => x.v).FirstOrDefault();

            string res = string.Join(" ", Enumerable.Range(1, ones).Select(x => 1)) + " " + string.Join(" ", Enumerable.Range(1, zeroes).Select(x => 0));
            res = res.Trim();
            Console.WriteLine(res);
        }

    }

}