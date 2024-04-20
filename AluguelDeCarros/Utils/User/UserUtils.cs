using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Utils.User
{
    public class UserUtils : IUserUtils
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IConfiguration _configuration;
        public UserUtils(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        
        public async Task<bool> RegisterUser(UsuarioDTO model)
        {

            var user = new Usuario
            {
                RealName = model.Name,
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return false;
            }
            await _signInManager.SignInAsync(user, false);
            return true;


        }
        
    
    
    
    
    }











    public interface IUserUtils {
        public Task<bool> RegisterUser(UsuarioDTO model);
    }

}
