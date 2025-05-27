namespace codeforces.challengesD;

//D. Black and White Stripe
public class Problem1690D
{

    public static void solution()
    {
        // solution with prefix sums 
        int tc = int.Parse(Console.ReadLine());
        for (int t = 0; t < tc; t++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int n, int k) = (input[0], input[1]);
            string stripe = Console.ReadLine();

            int[] acc = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                acc[i] = acc[i - 1] + (stripe[i - 1] == 'W' ? 1 : 0);
            }

            int ans = int.MaxValue;
            for (int i = k; i < n + 1; i++)
            {
                int diff = acc[i] - acc[i - k];
                ans = Math.Min(ans, diff);
            }

            System.Console.WriteLine(ans);
        }

        // Solution with sliding window
        for (int t = 0; t < tc; t++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int n, int k) = (input[0], input[1]);
            string stripe = Console.ReadLine();

            int countW = 0;
            // Contar 'W' en la primera ventana
            for (int i = 0; i < k; i++)
                if (stripe[i] == 'W') countW++;

            int ans = countW;
            // Mover la ventana
            for (int i = k; i < n; i++)
            {
                if (stripe[i - k] == 'W') countW--;
                if (stripe[i] == 'W') countW++;
                ans = Math.Min(ans, countW);
            }

            System.Console.WriteLine(ans);
        }
    }
}


