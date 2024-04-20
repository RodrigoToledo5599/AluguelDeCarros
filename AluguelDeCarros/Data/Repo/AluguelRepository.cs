using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo
{
    public class AluguelRepository : Repository<Aluguel>, IAluguelRepository
    {
        private readonly AppDbContext _db;
        public AluguelRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }

        

        
        public async Task<Aluguel> Alugar(Aluguel aluguel)
        {
            _db.Aluguel.Add(aluguel);
            _db.SaveChanges();

            return aluguel;

        }
        
        



    }
}
