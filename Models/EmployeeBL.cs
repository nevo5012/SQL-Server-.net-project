using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FinalProject_Factory7_1.Controllers;

namespace FinalProject_Factory7_1.Models
{
    public class EmployeeBL
    {
        factoryDBEntities db = new factoryDBEntities();

      public List<ViewModel> GetEmployeeViewModel()
        {
            using (factoryDBEntities db = new factoryDBEntities())
            {
                List<employees> employees = db.employees.ToList();
                List<EmployeeShift> employeeShifts = db.EmployeeShift.ToList();
                List<shifts> shifts = db.shifts.ToList();
             
                var employeeAndShift = from es in employeeShifts
                                        join e in employees on es.EmployeeID equals e.ID into table1
                                       from e in table1.ToList()
                                       join s in shifts on es.ShiftID equals s.ID into table2
                                       from s in table2.ToList()

                                       select new ViewModel
                                       {
                                           employeeShifts = es,
                                           employees = e,
                                           shifts = s
                                         
                                       };
                return employeeAndShift.ToList();
            }
      }

        public employees GetEmployee(int empID)
        {
            return db.employees.Where(x => x.ID == empID).First();
        }

        public void UpdateEmployee(employees emp)
        {
            var empToUpdate = db.employees.Where(x => x.ID == emp.ID).First();
            
            empToUpdate.FirstName = emp.FirstName;
            empToUpdate.LastName = emp.LastName;
            empToUpdate.YearStarted = emp.YearStarted;
            empToUpdate.DepID = emp.DepID;


            db.SaveChanges();
        }
        public void DeleteEmployee(int empId)
        {
            var empToDalete = db.employees.Where(x => x.ID == empId).First();

            db.employees.Remove(empToDalete);

            db.SaveChangesAsync();
        }
     



    }   
}