using System;

class Loops
{
    static void Main()
    {
        Console.WriteLine("For Loop:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;

            if (i == 9)
                break;

            Console.Write(i + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("While Loop:");

        int count = 1;

        while (count <= 5)
        {
            Console.Write(count + " ");
            count++;
        }

        Console.WriteLine("\n");

        string[] technologies =
        {
            "HTML5",
            "CSS3",
            "JavaScript",
            "CSharp"
        };

        Console.WriteLine("Foreach Loop:");

        foreach (string tech in technologies)
        {
            Console.WriteLine(tech);
        }
    }
}
