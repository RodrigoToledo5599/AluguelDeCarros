using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo
{
    public class CarrosRepository : Repository<Carros> , ICarrosRepository
    {
        private readonly AppDbContext _db;
        public CarrosRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
