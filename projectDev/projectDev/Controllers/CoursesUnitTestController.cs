using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectDev.Models;

namespace projectDev.Controllers
{
    public class CoursesUnitTestController : Controller
    {
        [NonAction]
        public List<Course> GetCourseList()
        {
            return new List<Course>
            {
                new Course
                {
                    CourseId = "I203",
                    CourseName = "Digital Multimedia",
                    Year = 2,
                    Semester = 1,
                    Prerequisites = "I101",
                },

                new Course
                {
                    CourseId = "T201",
                    CourseName = "Network Service",
                    Year = 2,
                    Semester = 1,
                    Prerequisites = "T101",
                },
            };

        }

        public IActionResult Index()
        {
            var course = from i in GetCourseList()
                         select i;
            return View(course);
        }

        public IActionResult Course()
        {
            var course = from e in GetCourseList()
                         orderby e.CourseId
                         select e;
            return View(course);
        }

    }
}