namespace codeforces.challengesA;

//A. Nastia and Nearly Good Numbers
public class Problem1521A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long a, long b) = (input[0], input[1]);

            long x = a * b;
            long y = a * (b + 1);
            long z = x + y;

            if (x == y || b == 1)
                System.Console.WriteLine("NO");
            else
            {
                System.Console.WriteLine("YES");
                System.Console.WriteLine($"{x} {y} {z}");
            }
        }
    }
}


