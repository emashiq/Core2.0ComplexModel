using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreComplexDataModel.Models
{
   public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength=1)]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}