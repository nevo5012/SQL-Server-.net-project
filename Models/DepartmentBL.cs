using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class DepartmentBL
    {
        factoryDBEntities db = new factoryDBEntities();

        public List<departWithManager> GetDepartments()
        {
            var result = from dep in db.department
                            join
                            emp in db.employees on dep.Manager equals emp.ID
                         select new departWithManager
                         {
                             ID = dep.ID,
                             Name = dep.DepName,
                             ManagerName = emp.FirstName + " " + emp.LastName
                         };


           return result.ToList();
        }

        public department GetDepartment2(int departID)
        {
           return db.department.Where(x => x.ID == departID).First();
        }

        public void UpdateDepartment(department depart)
        {
             var departToUpdate = db.department.Where(x => x.ID == depart.ID).First();
            departToUpdate.ID = depart.ID;
            departToUpdate.DepName = depart.DepName;
            departToUpdate.Manager = depart.Manager;

            db.SaveChanges();
        }
        public void DeleteDepartment(int departId)
        {
            var departToDalete = db.department.Where(x => x.ID == departId).First();

            db.department.Remove(departToDalete);

            db.SaveChanges();
        }
        public void AddDepartment(department depart)
        {
            db.department.Add(depart);

            db.SaveChanges();
        }
    }
}