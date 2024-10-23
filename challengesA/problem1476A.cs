namespace codeforces.challengesA;

//A. K-divisible Sum
public class Problem1476A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int n, int k) = (input[0], input[1]);

            if (n % k == 0)
                System.Console.WriteLine("1");
            else if (k % n == 0)
                System.Console.WriteLine(k / n);
            else if (n > k)
                System.Console.WriteLine("2");
            else
                System.Console.WriteLine((k / n) + 1);
        }
    }
}


