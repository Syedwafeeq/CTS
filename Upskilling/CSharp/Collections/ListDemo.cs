using System;
using System.Collections.Generic;

class ListDemo
{
    static void Main()
    {
        List<string> skills = new List<string>();

        skills.Add("HTML5");
        skills.Add("CSS3");
        skills.Add("JavaScript");
        skills.Add("CSharp");

        skills.Remove("CSS3");

        Console.WriteLine("Total Skills: " + skills.Count);

        foreach (string skill in skills)
        {
            Console.WriteLine(skill);
        }
    }
}
