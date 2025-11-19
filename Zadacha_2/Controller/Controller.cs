using ConsoleApp6.Model;
using ConsoleApp6.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Controller
{
    public class ExamArrivalController
    {
        private ExamArrivalModel Model;
        private ExamArrivalView View;

        public ExamArrivalController(ExamArrivalModel model, ExamArrivalView view)
        {
            this.Model = model;
            this.View = view;
        }

        public void Run()
        {
            Model.ExamHour = View.ReadHour("Час на изпита: ");
            Model.ExamMinute = View.ReadMinute("Минута на изпита: ");

            Model.ArrivalHour = View.ReadHour("Час на пристигане: ");
            Model.ArrivalMinute = View.ReadMinute("Минута на пристигане: ");

            int diff = Model.GetTimeDifference();

           
            if (diff > 0)
            {
                View.PrintStatus("Late");
            }
            else if (diff >= -30)
            {
                View.PrintStatus("On time");
            }
            else
            {
                View.PrintStatus("Early");
            }

           
            if (diff != 0)
            {
                int absDiff = Math.Abs(diff);
                int hours = absDiff / 60;
                int minutes = absDiff % 60;

                if (hours == 0)
                {
                    if (diff < 0)
                        View.PrintTimeDifference($"{minutes} minutes before the start");
                    else
                        View.PrintTimeDifference($"{minutes} minutes after the start");
                }
                else
                {
                    string formatted = $"{hours}:{minutes:D2}";
                    if (diff < 0)
                        View.PrintTimeDifference($"{formatted} hours before the start");
                    else
                        View.PrintTimeDifference($"{formatted} hours after the start");
                }
            }
        }
    }

}
