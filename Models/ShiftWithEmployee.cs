using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class ShiftWithEmployee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public System.DateTime ShiftDate { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}