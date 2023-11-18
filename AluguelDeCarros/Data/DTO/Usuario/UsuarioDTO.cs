using AluguelDeCarros.Enum;
using Microsoft.AspNetCore.Authorization;

namespace AluguelDeCarros.Data.DTO.Usuario
{
    public class UsuarioDTO : IAuthorizationRequirement
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Roles Role { get; set; }


    }
}
