using CourseApp.BLL.Abstract;
using CourseApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("GetAll")]
		public IActionResult GetAll()
		{
			var categories = _categoryService.GetAll();
			return Ok(categories);
		}

		[HttpPost("Add")]
		public IActionResult Add(Category category)
		{
			_categoryService.Add(category);
			return Ok();
		}

		[HttpPut("Update")]
		public IActionResult Update(int id, Category category)
		{
			if (id != category.Id)
			{
				return BadRequest("Invalid category id");
			}

			_categoryService.Update(category);
			return Ok();
		}

		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			var category = _categoryService.GetById(id);
			if (category == null)
			{
				return NotFound();
			}

			_categoryService.Remove(category);
			return Ok();
		}
	}
}
