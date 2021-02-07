using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class ViewModel
    {
        public employees employees { get; set; }
        public EmployeeShift employeeShifts { get; set; }
        public shifts shifts { get; set; }
         
        public department departments { get; set; }
        
    }
}