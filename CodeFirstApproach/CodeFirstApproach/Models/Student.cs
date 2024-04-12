using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Column("StudentName",TypeName = "varchar(100)")]
        public string name { get; set; }
        [Column("Gender", TypeName = "varchar(20)")]
        public string gender { get; set; }
        public int age { get; set; }
        public int standard { get; set; }
    }
}
