using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        public IUserServices _userServices { get; set; }
        public AccountController(IUserServices userServices)
        {
            _userServices = userServices;
        }


        [HttpPost("registerUser")]
        public async Task<IActionResult> RegisterUser([FromBody] UsuarioDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            bool registerResult = await _userServices.RegisterUser(model);
            var result = registerResult == true ? StatusCode(200, "Usuario criado") : StatusCode(400, "Bad Request (Senha fraca)");
            return result;
        }


        [HttpDelete("deleteUser")]
        public async Task<IActionResult> DeleteUser([FromBody] UsuarioDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }
            bool registerResult = await _userServices.DeleteUser(model);
            var result = registerResult == true ? StatusCode(200, "Usuario criado") : StatusCode(400, "Bad Request (Senha fraca)");
            return result;
        }

        [HttpDelete("deleteAllUsers")]
        public async Task<IActionResult> DeleteAllUsers()
        {
            var result = _userServices.DeleteAllUsers();
            return Ok(result);
        }


    }
}
