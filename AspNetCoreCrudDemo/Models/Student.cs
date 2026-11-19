
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCrudDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course Name is required")]
        public string Course { get; set; } = string.Empty;

        [Display(Name="Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }
    }
}

