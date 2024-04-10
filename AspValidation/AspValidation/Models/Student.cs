using System.ComponentModel.DataAnnotations;

namespace AspValidation.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Name is must")]
        [StringLength (50,MinimumLength = 5,ErrorMessage ="Length must be between 5 and 50")]
        public string name { get; set; }
        [Required(ErrorMessage ="Mail is must")]
        //[EmailAddress] not recommended
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$",ErrorMessage ="Invalid Mail")]
        public string email { get; set; }
        [Required(ErrorMessage ="Age is must")]
        [Range(21,30)]
        public int? age { get; set; }
        [Required(ErrorMessage ="Password is must")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Upper case,Lower case,Number,min 8")]
        public string password { get; set; }
    }
}
