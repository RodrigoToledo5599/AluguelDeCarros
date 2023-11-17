using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data.Repo
{
    public class MarcasRepository : IMarcasRepository
    {
        private readonly AppDbContext _db;
        public MarcasRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<DmMarcas>? getMarca(int id)
        {
            DmMarcas? result = await _db.DmMarcas.Where(c => c.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<DmMarcas>? getMarcaFromCarro(int idCarro)
        {
            Carros? carro = await _db.Carros.FirstOrDefaultAsync(c => c.Id == idCarro);
            int marcaId = carro.MarcaId;
            DmMarcas? result = await _db.DmMarcas.FirstOrDefaultAsync(m => m.Id == marcaId);
            return result;

        }
    }
}
