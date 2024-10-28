namespace codeforces.challengesB;

//B. Buttons
public class Problem268B
{

    public static void solution()
    {
        // 1*(n-1)+1 + 2*(n-2)+1 + 3*(n-3)+1 + ... + n*(n-n)+1
        long n = int.Parse(Console.ReadLine());

        long ans = (n - 1) * (n + 1) * n / 6 + n;
        System.Console.WriteLine(ans);
    }
}


