using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class UserBL
    {
        factoryDBEntities db = new factoryDBEntities();

       

        public bool IsAuthenticated(string username, string pwd)
        {
            var result = db.users.Where(x => x.UserName == username && x.Pwd == pwd);
            if (result.Count() == 0)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
        public string GetUserName(string userName)
        {
            return db.users.Where(x => x.UserName == userName).First().FullName;

        }

        

      public int getActionCounter(string username)
        {
            
            var aConter = db.users.Where(x => x.UserName == username).First().ActionsCounter;

            return aConter;
        }

        public void updateCounter(string username)
        {
            var actionCounter = db.users.Where(x => x.UserName == username).First();
            actionCounter.ActionsCounter += 1;
            db.SaveChanges();
        }
      
    }
}