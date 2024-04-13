using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Column("StudentName",TypeName = "varchar(100)")]
        [Required]
        public string name { get; set; }
        [Column("Gender", TypeName = "varchar(20)")]
        [Required]
        public string gender { get; set; }
        [Required]
        public int? age { get; set; }
        [Required]
        public int? standard { get; set; }
    }
}
