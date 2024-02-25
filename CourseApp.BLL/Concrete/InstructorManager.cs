using CourseApp.BLL.Abstract;
using CourseApp.Entities;

namespace CourseApp.BLL.Concrete
{
	public class InstructorManager : IInstructorService
	{
		private readonly IService<Instructor> _instructorService;

		public InstructorManager(IService<Instructor> instructorService)
		{
			_instructorService = instructorService;
		}

		public void Add(Instructor entity)
		{
			_instructorService.Add(entity);
		}

		public IEnumerable<Instructor> GetAll()
		{
			return _instructorService.GetAll();
		}

		public Instructor GetById(int id)
		{
			return _instructorService.GetById(id);
		}

		public void Remove(Instructor entity)
		{
			_instructorService.Remove(entity);
		}

		public void Update(Instructor entity)
		{
			_instructorService.Update(entity);
		}
	}
}
