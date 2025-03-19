using DEPI.BLL.DTOs.StudentDTO;
using DEPI.BLL.Services.StudentService;
using Microsoft.AspNetCore.Mvc;

namespace DEPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_studentService.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(_studentService.GetById(id));
        }
        [HttpPost]
        public ActionResult Add(StudentAddDTO student)
        {
            _studentService.Add(student);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, StudentUpdateDTO student)
        {
            if (id != student.Id)
                return BadRequest();

            _studentService.Update(id, student);
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return NoContent();
        }
        [HttpGet("by-email/{email}")]
        public ActionResult GetStudentByEmail(string email)
        {
            return Ok(_studentService.GetStudentByEmail(email));
        }
    }
}
