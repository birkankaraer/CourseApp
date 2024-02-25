using CourseApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Instructor> Instructors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>()
				.HasOne(c => c.Category)
				.WithMany(c => c.Courses)
				.HasForeignKey(c => c.CategoryId);

			modelBuilder.Entity<Course>()
				.HasOne(c => c.Instructor)
				.WithMany(i => i.Courses)
				.HasForeignKey(c => c.InstructorId);
		}
	}
}
