using System;
using System.Collections.Generic;

namespace projectDev.Models
{
    public partial class Students
    {
        public int StudentId { get; set; }
        public string AspNetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public AspNetUsers AspNet { get; set; }
    }
}
