using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class EmployeeWithShiftBL
    {
        factoryDBEntities db = new factoryDBEntities();

        public List<EmployeeShift> GetEmployeeShifts()
        {
            return db.EmployeeShift.ToList();
                     


             
        }
    }
}