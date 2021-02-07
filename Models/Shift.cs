using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime ShiftDate { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

    }
}