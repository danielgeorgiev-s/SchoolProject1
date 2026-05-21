using Microsoft.AspNetCore.Mvc;
using SchoolProject.Data;

namespace SchoolProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Age
                })
                .ToList();

            return Ok(students);
        }
    }
}