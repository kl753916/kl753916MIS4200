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
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Student Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Student Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your most frequently used email address")]
        public string email { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}