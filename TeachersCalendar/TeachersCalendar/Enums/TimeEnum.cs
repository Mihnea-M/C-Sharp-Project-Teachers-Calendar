using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalendar.Enums
{
    internal class TimeIntervalAttribute : Attribute
    {
        public string TimeInterval { get; }

        public TimeIntervalAttribute (string timeInterval)
        {
            TimeInterval = timeInterval;
        }

        public static string GetTimeInterval(TimeEnum slot)
        {
            var fieldInfo = slot.GetType().GetField(slot.ToString());
            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(TimeIntervalAttribute)) as TimeIntervalAttribute;

            return attribute?.TimeInterval ?? "Unknown";
        }

        public static TimeEnum GetTimeEnum(int index)
        {
            switch(index)
            {
                case 0:
                    return TimeEnum.Slot7300to0900;
                case 1:
                    return TimeEnum.Slot0900to1030;
                case 2:
                    return TimeEnum.Slot1030to1200;
                case 3:
                    return TimeEnum.Slot1200to1330;
                case 4:
                    return TimeEnum.Slot1330to1500;
                case 5:
                    return TimeEnum.Slot1500to1630;
                case 6:
                    return TimeEnum.Slot1630to1800;
            }
            return TimeEnum.Slot7300to0900;
        }
    }

    public enum TimeEnum
    {
        [TimeInterval("07:30 - 09:00")]
        Slot7300to0900 = 1,

        [TimeInterval("09:00 - 10:30")]
        Slot0900to1030 = 2,

        [TimeInterval("10:30 - 12:00")]
        Slot1030to1200 = 3,

        [TimeInterval("12:00 - 13:30")]
        Slot1200to1330 = 4,

        [TimeInterval("13:30 - 15:00")]
        Slot1330to1500 = 5,

        [TimeInterval("15:00 - 16:30")]
        Slot1500to1630 = 6,

        [TimeInterval("16:30 - 18:00")]
        Slot1630to1800 = 7
    }
}
