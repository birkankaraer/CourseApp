using CourseApp.BLL.Abstract;
using CourseApp.Entities;

namespace CourseApp.BLL.Concrete
{
	public class CourseManager : ICourseService
	{
		private readonly IService<Course> _courseService;

		public CourseManager(IService<Course> courseService)
		{
			_courseService = courseService;
		}

		public void Add(Course entity)
		{
			_courseService.Add(entity);
		}

		public IEnumerable<Course> GetAll()
		{
			return _courseService.GetAll();
		}

		public Course GetById(int id)
		{
			return _courseService.GetById(id);
		}

		public void Remove(Course entity)
		{
			_courseService.Remove(entity);
		}

		public void Update(Course entity)
		{
			_courseService.Update(entity);
		}
	}
}
