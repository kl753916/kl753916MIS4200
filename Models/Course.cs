using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kl753916MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }

        [Display (Name = "Course Description")]
        [Required(ErrorMessage ="Course Description is Required")]
        [StringLength(20)]
        public string courseDescription { get; set; }
        [Display(Name = "Credit Hours")]
        [Required(ErrorMessage = "Credit hours are Required")]
        [StringLength(2)]
        public string creditHours { get; set; }
        [Display(Name = "Course Rating")]
        [Required(ErrorMessage = "Course Rating is Required")]
        [StringLength(2)]
        public string courseRating { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }


        
    }
}