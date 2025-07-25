﻿using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "First name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string FirstMidName { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Entollment Data")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full name")]
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstMidName}";
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}