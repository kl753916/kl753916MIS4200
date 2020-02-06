using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kl753916MIS4200.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public string courseName { get; set; }
        public DateTime classTime { get; set; }

        // the next two properties link the courseDetail to the Course
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        // the next two properties link the courseDetail to the Student
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}