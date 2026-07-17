// 71A - WayTooLongWords
// https://codeforces.com/problemset/problem/71/A
// Tags: strings
// Difficulty: *800

int n = int.Parse(Console.ReadLine()!);
string[] words = new string[n];
for(int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine()!;
    if(words[i].Length > 10)
    {
        words[i] = $"{words[i][0]}{words[i].Length - 2}{words[i][^1]}";
    }
}

for(int i = 0; i < n; i++)
{
    Console.WriteLine(words[i]);
}