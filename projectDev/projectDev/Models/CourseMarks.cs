using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectDev.Models
{
    public class CourseMarks
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public string CourseId { get; set; }
        public int Yeartaken { get; set; }
        public int Semester { get; set; }
        public int CourseMark { get; set; }
        public string CourseGrade { get; set; }
        public bool CoursePass { get; set; }
    }
}
