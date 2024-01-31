using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using AluguelDeCarros.Services.Token;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    //[Authorize(AuthenticationSchemes ="Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser( [FromBody] UsuarioDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }

            var user = new Usuario
            {
                RealName = model.Name,
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user,model.Password);

            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _signInManager.SignInAsync(user, false);
            return Ok(user);


        }

        
        [HttpPost("login")]
        public async Task<ActionResult> Login(UsuarioSignIn model)
        { 
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }


            
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password,false,false);

            if (!result.Succeeded)
                return StatusCode(401,"Senha e/ou email estão errado(s) o sua mula");
            else
            {
                /*
                var tokenService = new TokenService(_configuration);
                var token = tokenService.GenerateToken(model.Email.ToString() ,model.Password.ToString());
                var usuarioToken = tokenService.GenerateUsuarioToken();
               */

                return Ok("nice mano");
            }
            
            


        }


    }
}
