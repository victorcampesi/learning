// 339A - Helpful Maths
// https://codeforces.com/problemset/problem/339/A
// Tags: greedy, implementation, sortings, strings 
// Difficulty: *800

string[] s = Console.ReadLine()!.Split('+');
Array.Sort(s);
Console.WriteLine(string.Join("+", s));