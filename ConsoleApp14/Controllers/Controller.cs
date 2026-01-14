using StudentGradeManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Controllers
{
    public class Controller
    {
        private readonly IStudentService studentService;
        public Controller(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public void AddStudent(string name, double grade)
        {
            studentService.AddStudent(name, grade);
        }
        public void ShowAllStudents()
        {
           Console.WriteLine( $"List of students:{studentService.GetAllStudents()}");
        }
        public void ShowBestStudent()
        {
           Console.WriteLine( $"Highest grade student is:{studentService.GetBestStudent()}");
        }
        public void ShowAverageGrade()
        {
            Console.WriteLine($"Average grade is:{studentService.GetAverageGrade()}:F2");
            
        }
    }
}
