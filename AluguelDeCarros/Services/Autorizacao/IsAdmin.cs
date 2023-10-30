using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authorization;

namespace AluguelDeCarros.Services.Autorizacao
{
    public class IsAdmin: AuthorizationHandler<UsuarioDTO>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UsuarioDTO usuario)
        {
            if (usuario.Role == Enum.Roles.Admin) 
            {
                context.Succeed(usuario);
                return Task.CompletedTask;
            }
            else
            {
                return Task.CompletedTask;
            }


        }

    }
}
