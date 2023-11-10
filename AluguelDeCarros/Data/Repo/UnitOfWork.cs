using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public ICarrosRepository Carros { get; private set; }

        

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            this.Carros = new CarrosRepository(_db);

        }

    }
}
