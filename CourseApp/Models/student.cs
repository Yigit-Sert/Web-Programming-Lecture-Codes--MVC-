using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class student
    {
        [Required(ErrorMessage ="Please Write Your Name!")]    //validation rules 
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please Write Your Email!")]
        [EmailAddress(ErrorMessage ="Please Write Correct EMail!")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Please Write Your Phone Number!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Please select one of the confirm option!")]
        public bool Confirm { get; set; }
    }
}