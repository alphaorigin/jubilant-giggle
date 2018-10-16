using System;
using System.Collections.Generic;

namespace projectDev.Models
{
    public partial class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int Marks { get; set; }
        public string Prerequisites { get; set; }
        public string CourseCatergory { get; set; }
        public bool? Complusory { get; set; }
    }
}
