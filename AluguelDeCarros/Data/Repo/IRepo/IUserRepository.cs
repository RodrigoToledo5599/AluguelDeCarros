using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.Repo.IRepo
{
    public interface IUserRepository
    {
        public Task<bool> CreateUser(Usuario model,string password);
        public Task<bool> DeleteUser(Usuario model);
        public Task<bool> DeleteAllUsers(List<Usuario> users);
        public List<Usuario> GetAllUsers();
    }
}
