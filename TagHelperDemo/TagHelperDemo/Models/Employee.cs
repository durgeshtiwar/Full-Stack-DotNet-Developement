namespace TagHelperDemo.Models
{
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public Gender Gender { get; set; }
        public string designation { get; set; }
        public int sallary { get; set; }
        public string married { get; set; }
        public string description { get; set; }

    }
    public enum Gender
    {
        Male,Female
    }
}
