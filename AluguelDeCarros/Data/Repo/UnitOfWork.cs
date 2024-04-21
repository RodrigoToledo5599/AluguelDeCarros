using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        private readonly UserManager<Usuario> _userManager;
        public ICarrosRepository Carros { get; private set; }
        public IMarcasRepository Marcas { get; private set; }
        public IAluguelRepository Aluguel { get; private set; }
        public IUserRepository User { get; private set; }

        public UnitOfWork(AppDbContext db,UserManager<Usuario> userManager)
        {
            _db = db;
            _userManager = userManager;
            this.Carros = new CarrosRepository(_db);
            this.Marcas = new MarcasRepository(_db);
            this.Aluguel = new AluguelRepository(_db);
            this.User = new UserRepository(_userManager,_db);
        }

    }
}
