using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachersCalendar.Enums;

namespace TeachersCalendar.Models
{
    [Serializable]
    public class ClassTime
    {
        public int Id { get; set; }
        private DayEnum day { get; set; }
        private TimeEnum time;
        public int DayIndex { get; set; }
        public int TimeIndex { get; set; }
        public ClassTime(int dayId ,int timeId)
        {
            DayIndex = dayId;
            TimeIndex = timeId;
            setDay(dayId);
            setTime(timeId);
        }

        public ClassTime(int id, int dayId ,int timeId)
        {
            this.Id = id;
            DayIndex = dayId;
            TimeIndex = timeId;
            setDay(dayId);
            setTime(timeId);
        }

        public void setTime(int timeId)
        {
            switch (timeId)
            {
                case 0:
                    time = TimeEnum.Slot7300to0900;
                    break;
                case 1:
                    time = TimeEnum.Slot0900to1030;
                    break;
                case 2:
                    time = TimeEnum.Slot1030to1200;
                    break;
                case 3:
                    time = TimeEnum.Slot1200to1330;
                    break;
                case 4:
                    time = TimeEnum.Slot1330to1500;
                    break;
                case 5:
                    time = TimeEnum.Slot1500to1630;
                    break;
                case 6:
                    time = TimeEnum.Slot1630to1800;
                    break;
            }
        }

        public string getTime()
        {
            return TimeIntervalAttribute.GetTimeInterval(time);
        }

        public static string getTime(int timeId)
        {
            return (new ClassTime(0, timeId).getTime());
        }

        public void setDay(int dayId)
        {
            switch (dayId)
            {
                case 1:
                    day = DayEnum.Monday;
                    break;
                case 2:
                    day = DayEnum.Tuesday;
                    break;
                case 3:
                    day = DayEnum.Wednesday;
                    break;
                case 4:
                    day = DayEnum.Thursday;
                    break;
                case 5:
                    day = DayEnum.Friday;
                    break;
            }
        }

        public string getDay()
        {
            return day.ToString();
        }

        public override string ToString()
        {
            return this.day + " at " + TimeIntervalAttribute.GetTimeInterval(time);
        }
    }
}
