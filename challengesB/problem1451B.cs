using System.Linq;
using System;

namespace codeforces.challengesB;

//1451/B. Non-Substring Subsequence
public class problem1451B
{

    static void print(string pref, IEnumerable<char> arr) => Console.WriteLine($"{pref} -> {string.Join("", arr)}");

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = dat[0]; //# length of string
            int queries = dat[1]; //# queries

            string s = Console.ReadLine();

            for (int i = 0; i < queries; i++)
            {
                var lr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int l = lr[0] - 1;
                int r = lr[1];

                string sub = s[l..r];
                //Console.WriteLine(string.Join("",sub));

                //we can iterare from index0 of the subsequence looking for the rest in a non adjacent position of array s
                bool found = false;
                for (int j = 1; j < sub.Length; j++)
                {
                    //print($"subsequence j:{j} ",sub[0..j]);

                    int indexFrom = s.IndexOf(sub[0..j].ToString()) + j + 1;
                    //print("string", s[indexFrom..]); 
                    //print("sub to search ",sub[j..]);
                    int rindex = s[indexFrom..].IndexOf(sub[j..]);
                    //Console.WriteLine("indexof: "+rindex);

                    if (s[indexFrom..].IndexOf(sub[j..]) >= 0)
                    {
                        found = true;
                        break;
                    }

                }

                Console.WriteLine(found ? "YES" : "NO");

            }
        }
    }
}


