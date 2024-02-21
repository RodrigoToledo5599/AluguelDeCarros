using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IAluguelRepository
    {
        public Task<AluguelAtivo> Alugar(AluguelAtivo aluguel);

    }
}
