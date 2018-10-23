using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectDev.Models
{
    public class Enrolments
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string CourseId { get; set; }
        public int YearTaken { get; set; }
        public int Semester { get; set; }
    }
}
