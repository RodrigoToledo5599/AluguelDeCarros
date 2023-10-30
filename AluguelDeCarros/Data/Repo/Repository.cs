using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using System.Linq.Expressions;

namespace AluguelDeCarros.Data.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AppDbContext _db;
        public Repository(AppDbContext db)
        {
            _db = db;
        }

        void IRepository<T>.Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        T IRepository<T>.Edit(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
            return entity;
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            IEnumerable<T> list = _db.Set<T>().ToList();
            return list;

        }

        T IRepository<T>.GetById(Expression<Func<T, bool>> filter)
        {
            T register = _db.Set<T>().Where(filter).FirstOrDefault();
            return register;
        }

        T IRepository<T>.Insert(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
            return entity;
        }
    }
}
