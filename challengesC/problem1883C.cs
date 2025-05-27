
namespace codeforces.challengesA;

//C. Raspberries
public class Problem1883C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        for (int t = 0; t < tc; t++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int n, int k) = (input[0], input[1]);
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int ans = int.MaxValue;
            int even = 0;
            foreach (int num in arr)
            {
                if (num % k == 0)
                {
                    ans = 0;
                    break;
                }
                else
                    ans = Math.Min(k - (num % k), ans);

                if (num % 2 == 0)
                    even++;
            }
            if (k == 4)
                ans = Math.Min(ans, (2 - Math.Min(2, even)));


            System.Console.WriteLine(ans);
        }
    }
}