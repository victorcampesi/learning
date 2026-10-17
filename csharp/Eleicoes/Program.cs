using System;
using System.IO;
namespace Eleicoes;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine()!;

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine()!.Split(',');
                    string name = lines[0];
                    int number = int.Parse(lines[1]);

                    if (votes.ContainsKey(name))
                    {
                        votes[name] += number;
                    }
                    else
                    {
                        votes[name] = number;
                    }
                }

                foreach(KeyValuePair<string, int> item in votes)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

