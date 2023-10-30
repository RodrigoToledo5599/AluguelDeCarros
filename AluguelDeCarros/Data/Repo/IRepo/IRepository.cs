using System.Linq.Expressions;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IRepository<T>
    {
        public T GetById(Expression<Func<T, bool>> filter);
        public IEnumerable<T> GetAll();
        public T Edit(T entity);
        public T Insert(T entity);
        public void Delete(T entity);

    }
}
