using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectDev.Models;

namespace projectDev.Controllers
{
    public class CourseMarksUnitTestController : Controller
    {
        [NonAction]
        public List<CourseMarks> GetCourseMarksList()
        {
            return new List<CourseMarks>
            {
                new CourseMarks
                {
                    ID = 123456,
                    StudentId = 100,
                    CourseId = "I203",
                    Yeartaken = 2014,
                    Semester = 1,
                    CourseMark = 83,
                    CourseGrade = "A",
                    CoursePass = true,
                },

                new CourseMarks
                {
                    ID = 123457,
                    StudentId = 101,
                    CourseId = "I204",
                    Yeartaken = 2015,
                    Semester = 2,
                    CourseMark = 84,
                    CourseGrade = "A",
                    CoursePass = true,
                },
            };

        }

        public IActionResult Index()
        {
            var courseMarks = from i in GetCourseMarksList()
                         select i;
            return View(courseMarks);
        }

        public IActionResult Course()
        {
            var courseMarks = from e in GetCourseMarksList()
                         orderby e.CourseId
                         select e;
            return View(courseMarks);
        }
    }
}