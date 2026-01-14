using StudentGradeManager.Services;
using System;
using System.Collections.Generic;
using ConsoleApp14.Services;
using ConsoleApp14.Views;
using ConsoleApp14.Controllers;

namespace ConsoleAppBad
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Controller controller = new Controller(service);
            View view = new View(controller);
            view.Run();
        }

    }
}
