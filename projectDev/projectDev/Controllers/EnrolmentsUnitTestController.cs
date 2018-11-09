using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectDev.Models;

namespace projectDev.Controllers
{
    public class EnrolmentsUnitTestController : Controller
    {
        [NonAction]
        public List<Enrolments> GetEnrolmentsList()
        {
            return new List<Enrolments>
            {
                new Enrolments
                {
                    ID = 100,
                    StudentID = 123456,
                    CourseId = "D202",
                    YearTaken = 2015,
                    Semester = 1,
                },

                new Enrolments
                {
                    ID = 100,
                    StudentID = 123456,
                    CourseId = "T201",
                    YearTaken = 2015,
                    Semester = 1,
                },
            };

        }

        public IActionResult Index()
        {
            var enrolments = from i in GetEnrolmentsList()
                             select i;
            return View(enrolments);
        }

        public IActionResult Enrolments()
        {
            var enrolments = from e in GetEnrolmentsList()
                             orderby e.CourseId
                             select e;
            return View(enrolments);
        }
    }

}