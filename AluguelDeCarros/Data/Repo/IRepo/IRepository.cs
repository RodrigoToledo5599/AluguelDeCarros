using System.Linq.Expressions;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IRepository<T>
    {
        public Task<T> GetById(Expression<Func<T, bool>> filter);
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<T>> GetIntervalo(int inicio, int QuantidadeDeElementos);
        public T Edit(T entity);
        public T Insert(T entity);
        public void Delete(T entity);

    }
}
