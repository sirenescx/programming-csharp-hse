using System;
using System.Collections.Generic;
using System.Linq;

public class Programmer
{
    public Programmer(string name, HashSet<string> knownLanguages)
    {
        Name = name;
        KnownLanguages = knownLanguages;
    }

    public HashSet<string> KnownLanguages { get; }
    public string Name { get; }
}

public class LanguagesStatistics
{
    public static HashSet<string> GetAll(List<Programmer> programmers)
    {
        var allLanguages = new HashSet<string>();
        foreach (var programmer in programmers)
        {
            allLanguages.UnionWith(programmer.KnownLanguages);
        }

        return allLanguages;
    }

    public static HashSet<string> GetKnownByAll(List<Programmer> programmers)
    {
        var knownByAll = new HashSet<string>(programmers[0].KnownLanguages);
        for (var i = 1; i < programmers.Count; ++i)
        {
            knownByAll.IntersectWith(programmers[i].KnownLanguages);
        }

        return knownByAll;
    }

    private static HashSet<string> GetUniqueForProgrammer(List<Programmer> programmers, int id)
    {
        var uniqueForProgrammer = new HashSet<string>();
        for (var i = 0; i < programmers.Count; ++i)
        {
            if (i == id)
            {
                continue;
            }

            uniqueForProgrammer.UnionWith(programmers[i].KnownLanguages);
        }

        var knownByIdLanguages = new HashSet<string>(programmers[id].KnownLanguages);
        knownByIdLanguages.ExceptWith(uniqueForProgrammer);
        return knownByIdLanguages;
    }

    public static List<HashSet<string>> GetUniqueForEachProgrammer(List<Programmer> programmers) => 
        programmers.Select((t, i) => GetUniqueForProgrammer(programmers, i)).ToList();
}

public class Program
{
    private static void PrintStatistics<T>(List<Programmer> programmers,
                                           Func<List<Programmer>, ICollection<T>> func)
    {
        var statistics = func(programmers);
        switch (statistics)
        {
            case List<HashSet<string>> _:
            {
                var i = 0;
                foreach (var programmerLanguages in statistics)
                {
                    Console.Write($"{programmers[i++].Name}: ");
                    if (programmerLanguages is HashSet<string> languages)
                    {
                        foreach (var language in languages)
                        {
                            Console.Write(language);
                        }
                    }

                    Console.WriteLine();
                }

                break;
            }

            case HashSet<string> _:
            {
                foreach (var language in statistics)
                {
                    Console.WriteLine(language);
                }

                break;
            }
        }
    }

    private static List<Programmer> ReadInfo()
    {
        var n = int.Parse(Console.ReadLine());
        var programmers = new List<Programmer>();
        for (var i = 0; i < n; ++i)
        {
            var args = Console.ReadLine().Split(';');
            var knownLanguages = new HashSet<string>();
            for (var j = 1; j < args.Length; ++j)
            {
                knownLanguages.Add(args[j]);
            }
            programmers.Add(new Programmer(args[0], knownLanguages));
        }

        return programmers;
    }

    public static void Main()
    {
        var programmers = ReadInfo();
        Console.WriteLine("All languages: ");
        PrintStatistics(programmers, LanguagesStatistics.GetAll);
        Console.WriteLine("Known by all languages: ");
        PrintStatistics(programmers, LanguagesStatistics.GetKnownByAll);
        Console.WriteLine("Unique for each programmer languages: ");
        PrintStatistics(programmers, LanguagesStatistics.GetUniqueForEachProgrammer);
    }
}