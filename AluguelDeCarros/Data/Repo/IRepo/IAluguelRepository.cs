using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IAluguelRepository
    {
        public Task<Aluguel> Alugar(Aluguel aluguel);

    }
}
