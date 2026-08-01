using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if (id == 1)
            {
                profile = "Employee 1 profile";
            }
            else if (id == 2)
            {
                profile = "Employee 2 profile";
            }
            else
            {
                profile = "No record";
            }
            return "Profile";
        }

        public string Address (int id, string department)
        {
            return "id = " +id + "dept = " +department;
        }
    }

}