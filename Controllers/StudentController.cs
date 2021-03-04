using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApplication3.Data;
using TestApplication3.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly Context _context;

        public StudentController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
        {
            var student = from Student in _context.Student
            join Student_descriptions in _context.Student_description on Student.Id equals Student_descriptions.Id
            select new StudentDTO
            {
                Student_id = Student.Id,
                Grade = Student.grade,
                Age = Student_descriptions.age,
                First_name = Student_descriptions.first_name,
                Last_name = Student_descriptions.last_name,
                Address = Student_descriptions.address,
                Country = Student_descriptions.country
            };

            return await student.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDTO> GetStudents_byId(int id)
        {
            var student = from Student in _context.Student
            join Student_descriptions in _context.Student_description on Student.Id equals Student_descriptions.Id
            select new StudentDTO
            {
                Student_id = Student.Id,
                Grade = Student.grade,
                Age = Student_descriptions.age,
                First_name = Student_descriptions.first_name,
                Last_name = Student_descriptions.last_name,
                Address = Student_descriptions.address,
                Country = Student_descriptions.country
            };

            var student_by_id = student.ToList().Find(x => x.Student_id == id);

            if (student_by_id == null)
            {
                return NotFound();
            }
            return student_by_id;
        }
    }
}