using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Model
{
    public class ExamArrivalModel
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }

        public int GetTimeDifference()
        {
            int examTotal = ExamHour * 60 + ExamMinute;
            int arrivalTotal = ArrivalHour * 60 + ArrivalMinute;

            return arrivalTotal - examTotal;
            
        }
    }

}
