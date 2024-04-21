using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Data.Repo
{

    public class UserRepository : IUserRepository
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly AppDbContext _db;
        public UserRepository(
                              UserManager<Usuario> userManager,
                              AppDbContext db
                              )
        {
            _userManager = userManager;
            _db = db;
        }
        




        public async Task<bool> CreateUser(Usuario model ,string password)
        {
            var result = await _userManager.CreateAsync(model, password);
            return result.Succeeded;
        }

        public async Task<bool> DeleteUser(Usuario model)
        {
            var result = await _userManager.DeleteAsync(model);
            return result.Succeeded;
        }

        public async Task<bool> DeleteAllUsers(List<Usuario> users)
        {
            foreach(var user in users)
            {
                await _userManager.DeleteAsync(user);
            }
            return true;
        }

        public List<Usuario> GetAllUsers()
        {
            var users = _db.Users.ToList();
            return users;
        }
        
    }
}
