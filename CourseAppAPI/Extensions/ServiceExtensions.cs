using CourseApp.BLL.Abstract;
using CourseApp.BLL.Concrete;
using CourseApp.DAL.Repositories;

namespace CourseAppAPI.Extensions
{
	public static class ServiceExtensions
	{
		public static void AddCustomServices(this IServiceCollection services)
		{
			services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
			services.AddScoped(typeof(IService<>), typeof(Service<>));
			services.AddScoped<ICourseService, CourseManager>();
			services.AddScoped<ICategoryService, CategoryManager>();
			services.AddScoped<IInstructorService, InstructorManager>();


		}
	}
}
