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
        private ExamArrivalModel model;
        private ExamArrivalView view;

        public ExamArrivalController(ExamArrivalModel model, ExamArrivalView view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            model.ExamHour = view.ReadHour("Час на изпита: ");
            model.ExamMinute = view.ReadMinute("Минута на изпита: ");

            model.ArrivalHour = view.ReadHour("Час на пристигане: ");
            model.ArrivalMinute = view.ReadMinute("Минута на пристигане: ");

            int diff = model.GetTimeDifference();

           
            if (diff > 0)
            {
                view.PrintStatus("Late");
            }
            else if (diff >= -30)
            {
                view.PrintStatus("On time");
            }
            else
            {
                view.PrintStatus("Early");
            }

           
            if (diff != 0)
            {
                int absDiff = Math.Abs(diff);
                int hours = absDiff / 60;
                int minutes = absDiff % 60;

                if (hours == 0)
                {
                    if (diff < 0)
                        view.PrintTimeDifference($"{minutes} minutes before the start");
                    else
                        view.PrintTimeDifference($"{minutes} minutes after the start");
                }
                else
                {
                    string formatted = $"{hours}:{minutes:D2}";
                    if (diff < 0)
                        view.PrintTimeDifference($"{formatted} hours before the start");
                    else
                        view.PrintTimeDifference($"{formatted} hours after the start");
                }
            }
        }
    }

}
