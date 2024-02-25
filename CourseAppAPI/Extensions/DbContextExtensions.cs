using CourseApp.DAL;
using Microsoft.EntityFrameworkCore;

namespace CourseAppAPI.Extensions
{
	public static class DbContextExtensions
	{
		public static void AddCustomDbContexts(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
		}
	}
}
