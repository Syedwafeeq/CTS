using System;
using System.Collections.Generic;

class HashSetDemo
{
    static void Main()
    {
        HashSet<string> technologies =
            new HashSet<string>();

        technologies.Add("HTML5");
        technologies.Add("CSS3");
        technologies.Add("JavaScript");
        technologies.Add("JavaScript");

        Console.WriteLine(
            "Contains CSS3: " +
            technologies.Contains("CSS3")
        );

        foreach (string tech in technologies)
        {
            Console.WriteLine(tech);
        }
    }
}
