namespace CourseApp.Entities
{
	public class Category : BaseEntity
	{
        public ICollection<Course>? Courses { get; set; }
    }
}
