using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18.Model;
using StudentGradeManager.Service;
namespace ConsoleApp18.Service
{
    public class Service
    {
        List<Student> students = new List<Student>();
        List<Grades> grades = new List<Grades>();
        public void AddStudent(string id, string name,double grade)
        {
            id = Console.ReadLine();
            name = Console.ReadLine();
            grade = double.Parse(Console.ReadLine());
            Student student = new Student(id, name);
            Grades result = new Grades(grade);
            students.Add(student);
            grades.Add(result);
        }

        public void ListAll()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " -> " + grades[i]);
            }
        }

        public void Best()
        {
            double max = double.MinValue;
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
    }
}