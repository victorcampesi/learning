// 231A - Team
// https://codeforces.com/problemset/problem/231/A
// Tags: brute force, greedy
// Difficulty: *800

int n = int.Parse(Console.ReadLine()!);
int problems = 0;

for(int i = 0; i < n; i++)
{
    int[] votes = Console.ReadLine()!
        .Split(' ')
        .Select(int.Parse)
        .ToArray();

    if(votes.Sum() >= 2)
    {
        problems++;
    }
}

Console.WriteLine(problems);