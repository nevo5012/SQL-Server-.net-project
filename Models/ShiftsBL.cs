using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class ShiftsBL
    {
        factoryDBEntities db = new factoryDBEntities();

        public void AddShift(shifts shifts)
        {
            db.shifts.Add(shifts);

            db.SaveChanges();
        }
        public List<ShiftWithEmployee> GetShifts()
        {
            var result = (from emp in db.employees
                          join
                          emp_sh in db.EmployeeShift on
                          emp.ID equals emp_sh.EmployeeID
                          join shifts in db.shifts on
                          emp_sh.ShiftID equals shifts.ID
                          select new ShiftWithEmployee
                          {
                              ID = emp.ID,
                              FullName = emp.FirstName + " " + emp.LastName,
                              ShiftDate = (System.DateTime)shifts.ShiftDate,
                              StartTime = (int)shifts.StartTime,
                              EndTime = (int)shifts.EndTime,
                          }).ToList();

            return result;
        }
     
    }
}