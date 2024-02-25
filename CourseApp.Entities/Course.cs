namespace CourseApp.Entities
{
	public class Course : BaseEntity
	{
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        public Category Category { get; set; }
        public Instructor Instructor { get; set; }
    }
}
