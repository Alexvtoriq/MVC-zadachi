using System;
using System.Collections.Generic;

namespace ConsoleAppBad
{
    internal class Program
    {
        static List<string> students = new List<string>();
        static List<double> grades = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("student grade app");
            while (true)
            {
                Console.WriteLine("1 add");
                Console.WriteLine("2 list");
                Console.WriteLine("3 best");
                Console.WriteLine("4 exit");

                if (command == "1")
                {
                    Console.WriteLine("name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("grade:");
                    var grade = double.Parse(Console.ReadLine());
                    students.Add(name);
                    grades.Add(grade);
                }
                else if (command == "2")
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine(students[i] + " -> " + grades[i]);
                    }
                }
                else if (command == "3")
                {
                    double max = -1;
                    string name = "";
                    for (int i = 0; i < grades.Count; i++)
                    {
                        if (grades[i] > max)
                        {
                            max = grades[i];
                            name = students[i];
                        }
                    }
                    Console.WriteLine("best: " + name + " " + max);
                }
                else if (command == "4")
                {
                    return;
                }
            }
        }
    }
}

