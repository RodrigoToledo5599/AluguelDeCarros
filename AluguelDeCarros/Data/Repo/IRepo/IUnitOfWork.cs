using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IUnitOfWork
    {
        ICarrosRepository Carros { get; }
        IMarcasRepository Marcas { get; }



    }
}
