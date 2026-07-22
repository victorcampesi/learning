// 282A - Bit++
// https://codeforces.com/problemset/problem/282/A
// Tags: implementation
// Difficulty: *800

int n = int.Parse(Console.ReadLine()!);
int x = 0;

for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;
    x = s.Contains('+') ? x + 1 : x - 1;
}

Console.WriteLine(x);
    
