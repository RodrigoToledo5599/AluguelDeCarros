using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo
{
    public class AluguelRepository : Repository<AluguelAtivo>, IAluguelRepository
    {
        private readonly AppDbContext _db;
        public AluguelRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }

        

        
        public async Task<AluguelAtivo> Alugar(AluguelAtivo aluguel)
        {
            _db.AluguelAtivos.Add(aluguel);
            _db.SaveChanges();

            return aluguel;

        }
        
        



    }
}
