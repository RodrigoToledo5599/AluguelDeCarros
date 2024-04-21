using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AluguelDeCarros.Utils.User;

namespace AluguelDeCarros.Controllers
{
    //[Authorize(AuthenticationSchemes ="Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        public IUserUtils _userUtils { get; set; }
        public AuthenticationController(IUserUtils userUtils)
        {
            _userUtils = userUtils;
        }




        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser( [FromBody] UsuarioDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            bool registerResult = await _userUtils.RegisterUser(model);
            var result = registerResult == true ? StatusCode(200, "Usuario criado"): StatusCode(400, "Bad Request (Senha fraca)");
            return result;

        }

        /*
        */
        [HttpPost("login")]
        public async Task<ActionResult> Login(UsuarioSignInDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            bool loginResult = await _userUtils.LoggingUser(model);
            var result = loginResult == true ? StatusCode(200, "Usuario logado") : StatusCode(401, "Não authorizado"); 
            return result;




        }



         
    }
}
