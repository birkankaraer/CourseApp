using CourseApp.BLL.Abstract;
using CourseApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CourseAppAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly ICourseService _courseService;

		public CourseController(ICourseService courseService)
		{
			_courseService = courseService;
		}
		[HttpGet("GetAll")]
		public IActionResult GetAll()
		{
			var courses = _courseService.GetAll();
			return Ok(courses);
		}
		[HttpPost("Add")]
		public IActionResult Add(Course course)
		{
			_courseService.Add(course);
			return Ok();
		}
		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			var course = _courseService.GetById(id);
			if(course == null)
			{
				return NotFound();
			}
			_courseService.Remove(course);
			return Ok();
		}
		[HttpPut("Update")]
		public IActionResult Update(int id, Course course)
		{
			if (id != course.Id)
			{
				return BadRequest("Invalid course id");
			}

			_courseService.Update(course);
			return Ok();
		}
	}
}
