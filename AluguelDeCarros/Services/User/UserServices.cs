using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserServices(UserManager<Usuario> userManager,
                         SignInManager<Usuario> signInManager,
                         IConfiguration configuration,
                         IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _mapper = mapper;
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
            return result.Succeeded;
        }

        public async Task<bool> LoggingUser(UsuarioSignInDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user is null)
                return false;
            return await _userManager.CheckPasswordAsync(user, model.Password);
        }
    }




    public interface IUserServices
    {
        public Task<bool> RegisterUser(UsuarioDTO model);
        public Task<bool> LoggingUser(UsuarioSignInDTO model);


    }
}
