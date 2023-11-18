using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AluguelDeCarros.Services.Token
{
    public class TokenService
    {
        private IConfiguration _configuration;


        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public UsuarioToken GenerateUsuarioToken(JwtSecurityToken token)
        {
            return new UsuarioToken()
            {
                Authenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.InnerToken.ValidTo,
                Message = "Tokenzao pronto"

            };
        }


        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
    
                new Claim("Email", usuario.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signingCredentials =
                new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                issuer: _configuration["TokenConfig:Issuer"],
                audience: _configuration["TokenConfig:Audience"],
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["TokenConfig:ExpireMinutes"])),
                claims: claims,
                signingCredentials: signingCredentials
                ) ;

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    
    }

}
