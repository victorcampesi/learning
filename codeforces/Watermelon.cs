// 4A - Watermelon
// https://codeforces.com/problemset/problem/4/A
// Tags: brute force, math
// Difficulty: *800

int weight = int.Parse(Console.ReadLine()!);
Console.WriteLine(weight % 2 == 0 && weight != 2? "YES" : "NO");