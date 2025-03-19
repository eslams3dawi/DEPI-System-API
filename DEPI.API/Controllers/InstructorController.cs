using DEPI.BLL.DTOs.InstructorDTO;
using DEPI.BLL.Services.InstructorService;
using Microsoft.AspNetCore.Mvc;

namespace DEPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        public readonly IInstructorService _instructorService;
        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [HttpPost]
        public ActionResult Add(InstructorAddDTO instructor)
        {
            _instructorService.Add(instructor);
            return NoContent();
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_instructorService.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(_instructorService.GetById(id));
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id, InstructorUpdateDTO instructor)
        {
            if (id != instructor.Id)
                return BadRequest();

            _instructorService.Update(id, instructor);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _instructorService.Delete(id);
            return NoContent();
        }
    }
}
