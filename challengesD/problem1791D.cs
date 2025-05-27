namespace codeforces.challengesD;

//D. Distinct Split
public class ClaseBase
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        for (int i = 0; i < tc; i++)
        {
            int l = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // Precalculate the number of distinct characters from the left and from the right at each index
            // and then find the maximum sum of distinct characters from both sides
            HashSet<char> set = new();
            HashSet<char> set2 = new();

            int[] count = new int[l];
            int[] countReverse = new int[l];

            for (int j = 0; j < l; j++)
            {
                set.Add(input[j]);
                count[j] = set.Count;
                set2.Add(input[l - 1 - j]);
                countReverse[l - 1 - j] = set2.Count;
            }

            int ans = 0;
            for (int j = 0; j < l - 1; j++)
            {
                ans = Math.Max(ans, count[j] + countReverse[j + 1]);
            }

            Console.WriteLine(ans);
        }
    }
}


