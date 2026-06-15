using System;
using System.Collections.Generic;

class DictionaryDemo
{
    static void Main()
    {
        Dictionary<int, string> students =
            new Dictionary<int, string>();

        students.Add(101, "Jaswanth");
        students.Add(102, "Rahul");
        students.Add(103, "Ananya");

        if (students.ContainsKey(101))
        {
            Console.WriteLine(students[101]);
        }

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine(
                student.Key + " : " + student.Value
            );
        }
    }
}
