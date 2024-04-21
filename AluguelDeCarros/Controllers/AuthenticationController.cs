using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AluguelDeCarros.Services.User;


namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        public IUserServices _userServices { get; set; }
        public AuthenticationController(IUserServices userServices)
        {
            _userServices = userServices;
        }




        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser( [FromBody] UsuarioDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            bool registerResult = await _userServices.RegisterUser(model);
            var result = registerResult == true ? StatusCode(200, "Usuario criado") : StatusCode(400, "Bad Request (Senha fraca)");
            return result;

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UsuarioSignInDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }

            string loginResult = await _userServices.LoggingUser(model);
            //var result = loginResult == true ? StatusCode(200, "Usuario logado") : StatusCode(401, "Não authorizado");

            return Ok(loginResult);

        }



         
    }
}
