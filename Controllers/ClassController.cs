using Microsoft.AspNetCore.Mvc;
using YogaClassManagement.Models;
using System.Collections.Generic;

namespace YogaClassManagement.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Schedule()
        {
            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Yoga Basics", Instructor = "Alice", Schedule = System.DateTime.Now },
                new Class { ClassId = 2, ClassName = "Advanced Yoga", Instructor = "Bob", Schedule = System.DateTime.Now.AddDays(1) }
            };
            return View(classes);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
