using System.ComponentModel.DataAnnotations;

namespace AlicanteITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string InsFirst { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string InsLast { get; set; }
        [Display(Name = "Employment Status")]
        public Boolean IsTenured { get; set; }
        [Display(Name = "Rank")]
        public Rank InstructorRank { get; set; }
        [Display(Name = "Date Hired")]
        [Required(ErrorMessage = "Please select an Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime? HiringDate { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter a valid Phone Number")]
        [RegularExpression("[0-9]{4}-[0-9]{3}-[0-9]{4}", ErrorMessage = "You must follow the format 0000-000-0000 for your Phone Number")]
        public string? PhoneNumber { get; set; }

    }
}
