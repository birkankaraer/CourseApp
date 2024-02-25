using CourseApp.BLL.Abstract;
using CourseApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class InstructorController : ControllerBase
	{
		private readonly IInstructorService _instructorService;

		public InstructorController(IInstructorService instructorService)
		{
			_instructorService = instructorService;
		}

		[HttpGet("GetAll")]
		public IActionResult GetAll()
		{
			var instructors = _instructorService.GetAll();
			return Ok(instructors);
		}

		[HttpPost("Add")]
		public IActionResult Add(Instructor instructor)
		{
			_instructorService.Add(instructor);
			return Ok();
		}

		[HttpPut("Update")]
		public IActionResult Update(int id, Instructor instructor)
		{
			if (id != instructor.Id)
			{
				return BadRequest("Invalid instructor id");
			}

			_instructorService.Update(instructor);
			return Ok();
		}

		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			var instructor = _instructorService.GetById(id);
			if (instructor == null)
			{
				return NotFound();
			}

			_instructorService.Remove(instructor);
			return Ok();
		}
	}
}
