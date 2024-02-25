using CourseApp.BLL.Abstract;
using CourseApp.DAL.Repositories;

namespace CourseApp.BLL.Concrete
{
	public class Service<TEntity> : IService<TEntity> where TEntity : class
	{
		private readonly IRepository<TEntity> _repository;

		public Service(IRepository<TEntity> repository)
		{
			_repository = repository;
		}

		public void Add(TEntity entity)
		{
			_repository.Add(entity);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _repository.GetAll();
		}

		public TEntity GetById(int id)
		{
			return _repository.GetById(id);
		}

		public void Remove(TEntity entity)
		{
			_repository.Remove(entity);
		}

		public void Update(TEntity entity)
		{
			_repository.Update(entity);
		}
	}
}
