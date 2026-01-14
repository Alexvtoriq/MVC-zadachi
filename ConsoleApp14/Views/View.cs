using ConsoleApp14.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Views
{
    public class View
    {
        private readonly Controller controller;
        public View (Controller controller)
        {
            this.controller = controller;
        }
        
        public void Run()
        {
            while(true)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("1: Add student");
                Console.WriteLine("2: List all students");
                Console.WriteLine("3: Show best student");
                Console.WriteLine("4: Show average grade");
                Console.WriteLine("5: Exit");
                if (input == 1)
                {
                    string name = Console.ReadLine();
                    double grade = double.Parse(Console.ReadLine());
                    controller.AddStudent(name,grade);
                }
                if(input == 2)
                {
                    controller.ShowAllStudents();
                }
                if( input == 3)
                {
                    controller.ShowBestStudent();
                }
                if(input == 4)
                {
                    controller.ShowAverageGrade();
                }
                if (input == 5)
                {
                    break;
                }
            }
          
        }
    }
}
