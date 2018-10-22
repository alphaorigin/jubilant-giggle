using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectDev.Models
{
    public partial class Course
    {
        public string CourseId { get; set; }

        [Display(Name = "Name")]
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int Marks { get; set; }
        public string Prerequisites { get; set; }

        [Display(Name = "Category")]
        public string CourseCatergory { get; set; }

        [Display(Name = "Compulsory")]
        public bool? Complusory { get; set; }
    }
}
