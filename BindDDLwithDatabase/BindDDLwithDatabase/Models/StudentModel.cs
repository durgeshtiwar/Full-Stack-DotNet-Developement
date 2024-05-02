using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindDDLwithDatabase.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public List<SelectListItem> studentList { get; set; }
    }
}
