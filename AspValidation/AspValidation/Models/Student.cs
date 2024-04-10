using System.ComponentModel.DataAnnotations;

namespace AspValidation.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Name must Enter")]
        [StringLength (50,MinimumLength = 5,ErrorMessage ="Length must be between 5 and 50")]
        public string name { get; set; }
    }
}
