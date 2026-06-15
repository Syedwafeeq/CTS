using System;
using System.IO;

class FileHandlingDemo
{
    static void Main()
    {
        string path = "sample.txt";

        File.WriteAllText(
            path,
            "Welcome to Cognizant Digital Nurture 5.0"
        );

        string content = File.ReadAllText(path);

        Console.WriteLine(content);
    }
}
