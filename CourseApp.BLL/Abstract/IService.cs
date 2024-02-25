namespace CourseApp.BLL.Abstract
{
    public interface IService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
		TEntity GetById(int id);
		void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
