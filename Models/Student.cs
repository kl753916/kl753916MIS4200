using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kl753916MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display(Name = "Student Full Name")]
        public string fullName { get { return lastName + ", " + firstName; } }

        [Display(Name = "Student First Name")]
        public string firstName { get; set; }
        [Display(Name = "Student Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Student Email")]
        public string email { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}