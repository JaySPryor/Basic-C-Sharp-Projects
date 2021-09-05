using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class Week
    {
        //Property of Week class
        public DayOfWeek dayOfWeek { get; set; }
    }
    //enum values
    public enum DayOfWeek
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
}
