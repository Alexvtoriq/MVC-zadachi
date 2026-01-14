using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14.Models;
using StudentGradeManager.Services;
namespace ConsoleApp14.Services
{
    public class Service : IStudentService
    {

        public List<Student> students = new List<Student>();
        private int Id = 1;
        public void AddStudent(string name, double grade)
        {
            foreach(Student student in students)
            {
                if(student.Name == name)
                {
                    throw new ArgumentException("Student with same name already exists");
                }
            }
            if(grade < 2.0 || grade > 6.0)
            {
                throw new ArgumentException("Grade is out of bounds");
            }
            if (name == "" || name == null)
            {
                throw new ArgumentException("Name is required");
            }
            students.Add(new Student(Id++,name,grade));
        }
        private IReadOnlyCollection<Student> GetStudents()
        {
           return students;
        }
        public Student? GetBestStudent()
        {
            Student beststudent = null;
            foreach (Student student in students)
            {
                if(student.Grade >= beststudent.Grade)
                {
                    beststudent.Grade = student.Grade;
                }
            }
            return beststudent;
        }
            

        public void GetAverageGrade()
        {
            double sum = 0;
            double averagegrade = 0;
            foreach (Student student in students)
            {
                sum += student.Grade;
            }
            averagegrade = sum / students.Count;
        }
    }
}
