using System.ComponentModel.DataAnnotations;

namespace TestApplication3.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string grade { get; set; }
    }
}