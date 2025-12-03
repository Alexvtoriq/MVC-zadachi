using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Model
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        
        public Student(string id, string name)
        {
            ID = id;
            Name = name;
            
        }
    }
    public class Grades
    {
        public double Grade { get; set; }
        public Grades(double grade)
        {
            Grade = grade;
        }
    }
}
