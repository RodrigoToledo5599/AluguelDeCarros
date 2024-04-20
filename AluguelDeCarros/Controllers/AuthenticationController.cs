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
            var result = registerResult == true ? StatusCode(400, "deu ruim") : StatusCode(200, "deu bom");
            return result;

        }

        /*
        [HttpPost("login")]
        public async Task<ActionResult> Login(UsuarioSignIn model)
        { 
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password,true,false);

            if (!result.Succeeded)
                return StatusCode(401,"Senha e/ou email estão errado(s) o sua mula");
            else
            {
                
                var tokenService = new TokenService(_configuration);
                var token = tokenService.GenerateToken(model.Email.ToString() ,model.Password.ToString());
                var usuarioToken = tokenService.GenerateUsuarioToken();
                
                return Ok(result);
            }
        }
        */



         
    }
}
