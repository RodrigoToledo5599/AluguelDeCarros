using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public ICarrosRepository Carros { get; private set; }
        public IMarcasRepository Marcas { get; private set; }
        public IAluguelRepository Aluguel { get; private set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            this.Carros = new CarrosRepository(_db);
            this.Marcas = new MarcasRepository(_db);
            this.Aluguel = new AluguelRepository(_db);
        }

    }
}
