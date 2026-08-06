using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(Student student)
        {
            return Json(new
            {
                success = true,
                message = "Student Saved Successfully."
            });
        }
    }
}