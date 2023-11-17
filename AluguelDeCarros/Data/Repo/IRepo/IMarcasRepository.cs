using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IMarcasRepository
    {
        Task<DmMarcas>? getMarca(int id);
        Task<DmMarcas>? getMarcaFromCarro(int idCarro);
    }
}
