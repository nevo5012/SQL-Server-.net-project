using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Factory7_1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public int ActionsCounter { get; set; }
        public int LastActionDay { get; set; }
    }
}