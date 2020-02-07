using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kl753916MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseDescription { get; set; }
        public string creditHours { get; set; } 
        public string courseRating { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }


        
    }
}