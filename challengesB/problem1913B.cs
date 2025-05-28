
namespace codeforces.challengesB;

//B. Swap and Delete
public class Problem1913B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        for (int t = 0; t < tc; t++)
        {
            string s = Console.ReadLine();

            var a = s.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            if (!a.ContainsKey('0'))
                a['0'] = 0;
            if (!a.ContainsKey('1'))
                a['1'] = 0;

            int ans = 0;
            if (s.Length == 1)
                ans = 1;
            else if (a['0'] == a['1'])
                ans = 0;
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1')
                        a['0']--;
                    else if (s[i] == '0')
                        a['1']--;

                    if (a['0'] < 0 || a['1'] < 0)
                    {
                        ans = s.Length - i;
                        break;
                    }
                }
            }

            System.Console.WriteLine(ans);
        }
    }
}
