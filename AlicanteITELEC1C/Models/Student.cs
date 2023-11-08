using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AlicanteITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "GPA")]
        [Required(ErrorMessage = "Please Enter GPA")]
        [Range(1.00, 5.00, ErrorMessage = "GPA must only be in the range between 1.00 - 5.00")]
        public double? GPA { get; set; }

        public Course? Course { get; set; }

        [Display(Name = "Admission Date")]
        [Required(ErrorMessage = "Please select an Admission Date")]
        public DateTime? AdmissionDate { get; set; }

        [EmailAddress]
        [Display(Name = "Email Adress")]
        [Required(ErrorMessage = "Please enter a valid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter a valid Phone Number")]
        [RegularExpression("[0-9]{4}-[0-9]{3}-[0-9]{4}", ErrorMessage = "You must follow the format 0000-000-0000 for your Phone Number")]
        public string? PhoneNumber { get; set; }

    }
}
