using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1569/A. Balanced Substring
    public class problem1569A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var cad = Console.ReadLine();

                if (cad.Length == 1 || cad.Count(x => x == 'a') == 0 || cad.Count(x => x == 'b') == 0)
                {
                    Console.WriteLine("-1 -1");
                }
                else
                {
                    int l = 0, r = n;

                    while (l < r)
                    {
                        string substr = cad[l..r];
                        //Console.WriteLine("substr:"+substr+" l:"+l+" r:"+r);

                        var tA = substr.Count(x => x == 'a');
                        var tB = substr.Count(x => x == 'b');
                        if (tA == tB)
                        {
                            break;
                        }
                        else
                        {
                            if (tA > tB)
                            {
                                if (substr[0] == 'a')
                                    l++;
                                else
                                    r--;
                            }
                            else
                            {
                                if (substr[0] == 'b')
                                    l++;
                                else
                                    r--;
                            }
                        }
                    }

                    Console.WriteLine($"{l + 1} {r}");

                }
            }
        }

    }

}