namespace codeforces.challengesA;

//A. Jzzhu and Children
public class Problem450A
{

    struct Child
    {
        public int position;
        public int totalCandies;
    }

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        (int n, int m) = (input[0], input[1]);

        var candies = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Queue<Child> queue = new(Enumerable.Range(0, n).Select(x => new Child() { position = x, totalCandies = 0 }));


        while (queue.Count > 1)
        {
            Child child = queue.Dequeue();
            child.totalCandies += m;

            if (child.totalCandies < candies[child.position])
                queue.Enqueue(child);
        }

        System.Console.WriteLine($"{queue.Peek().position + 1}");

    }
}


