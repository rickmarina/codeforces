using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1729/B. Decode String
    public class problem1729B
    {

        public static void solution()
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var input = Console.ReadLine();

                string res = "";
                for (int i = n - 1; i >= 0; i--)
                {
                    string l;
                    if (input[i] == '0')
                    {
                        l = letters[int.Parse(input[i - 2].ToString() + input[i - 1].ToString()) - 1].ToString();
                        i -= 2;
                    }
                    else
                    {
                        l = letters[int.Parse(input[i].ToString()) - 1].ToString();
                    }
                    res = l + res;
                }

                Console.WriteLine(res);


            }

        }

    }

}