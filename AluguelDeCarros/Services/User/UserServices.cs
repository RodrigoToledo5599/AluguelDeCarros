using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace AluguelDeCarros.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IConfiguration _configuration;
        //private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public UserServices(
                           UserManager<Usuario> userManager,
                           SignInManager<Usuario> signInManager,
                           IConfiguration configuration,
                           //IMapper mapper,
                           IConfiguration config
                           )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            //_mapper = mapper;
            _config = config;
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

        public async Task<string> LoggingUser(UsuarioSignInDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user is null)
                return "conta nao encontrada";
            return _GenerateTokenString(model);
            
        }

        public string _GenerateTokenString(UsuarioSignInDTO user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,user.Email),
                //new Claim(ClaimTypes.Role,"Admin"),
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));

            var signingCred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(365),
                issuer: _config.GetSection("Jwt:Issuer").Value,
                audience: _config.GetSection("Jwt:Audience").Value,
                signingCredentials: signingCred);

            string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return tokenString;
        }
    }




    public interface IUserServices
    {
        public Task<bool> RegisterUser(UsuarioDTO model);
        public Task<string> LoggingUser(UsuarioSignInDTO model);
        public string _GenerateTokenString(UsuarioSignInDTO user);


    }
}
