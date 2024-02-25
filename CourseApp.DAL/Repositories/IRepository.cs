namespace CourseApp.DAL.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetById(int id);
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Remove(TEntity entity);
	}
}
