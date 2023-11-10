using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
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

        async Task<IEnumerable<T>> IRepository<T>.GetAll()
        {
            IEnumerable<T> list = await _db.Set<T>().ToListAsync();
            return list;

        }

        async Task<IEnumerable<T>> IRepository<T>.GetIntervalo(int inicio, int QuantidadeDeElementos)
        {
            IEnumerable<T> list = await _db.Set<T>().Skip(inicio).Take(QuantidadeDeElementos - inicio).ToListAsync();
            return list;

        }


        async Task<T> IRepository<T>.GetById(Expression<Func<T, bool>> filter)
        {
            T register = await _db.Set<T>().Where(filter).FirstOrDefaultAsync();
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
