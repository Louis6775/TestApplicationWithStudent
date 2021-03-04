using System.ComponentModel.DataAnnotations;

namespace TestApplication3.Models
{
    public class Student_description
    {
        [Key]
        public int Id { get; set; }
        public int age { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string country { get; set; }
    }
}