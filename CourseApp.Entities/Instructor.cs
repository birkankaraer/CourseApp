namespace CourseApp.Entities
{
	public class Instructor : BaseEntity
	{
        public ICollection<Course>? Courses { get; set; }
    }
}
