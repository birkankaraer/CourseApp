using CourseApp.BLL.Abstract;
using CourseApp.Entities;

namespace CourseApp.BLL.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly IService<Category> _categoryService;

		public CategoryManager(IService<Category> categoryService)
		{
			_categoryService = categoryService;
		}

		public void Add(Category entity)
		{
			_categoryService.Add(entity);
		}

		public IEnumerable<Category> GetAll()
		{
			return _categoryService.GetAll();
		}

		public Category GetById(int id)
		{
			return _categoryService.GetById(id);
		}

		public void Remove(Category entity)
		{
			_categoryService.Remove(entity);
		}

		public void Update(Category entity)
		{
			_categoryService.Update(entity);
		}
	}
}
