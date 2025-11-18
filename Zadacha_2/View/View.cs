using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.View
{
    
    public class ExamArrivalView
    {
        public int ReadHour(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public int ReadMinute(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void PrintStatus(string status)
        {
            Console.WriteLine(status);
        }

        public void PrintTimeDifference(string message)
        {
            Console.WriteLine(message);
        }
    }

}
