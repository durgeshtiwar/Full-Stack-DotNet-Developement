using System.ComponentModel.DataAnnotations;

namespace ASPCURDApplictionUsingApi.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string studentName { get; set; } = null!;
        [Required]
        public string gender { get; set; } = null!;
        [Required]
        public int age { get; set; }
        [Required]
        public int standard { get; set; }
    }
}