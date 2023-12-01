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
        protected JwtSecurityToken Token;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public JwtSecurityToken GenerateToken(string Email, string Senha)
        {
            Claim[] claims = new Claim[]
            {
    
                new Claim("Email", Email),
                new Claim("Senha", Senha),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signingCredentials =
                new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            this.Token = new JwtSecurityToken(
                issuer: _configuration["TokenConfig:Issuer"],
                audience: _configuration["TokenConfig:Audience"],
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["TokenConfig:ExpireMinutes"])),
                claims: claims,
                signingCredentials: signingCredentials
                );

            
            return this.Token;

        }
        public UsuarioToken GenerateUsuarioToken()
        {
            return new UsuarioToken()
            {
                Authenticated = true,
                UserToken = new JwtSecurityTokenHandler().WriteToken(this.Token),
                Expiration = Token.InnerToken.ValidTo,
                Message = "Tokenzao pronto"
            };
        }



        public string TokenString()
        {
            return new JwtSecurityTokenHandler().WriteToken(Token);
        }
    
        
    }

}
