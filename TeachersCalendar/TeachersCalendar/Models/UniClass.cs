using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalendar.Models
{
    [Serializable]
    public class UniClass
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public Room Room { get; set; }
        public ClassTime ClassTime { get; set; }

        public UniClass() { }
    }
}
