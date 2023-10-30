using AluguelDeCarros.Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly AppDbContext _db;
        public AuthenticationController(AppDbContext db) 
        {
            _db = db;
        }


        //[Authorize(Policy ="222")]
        [HttpGet]
        public IActionResult Autenticar()
        {
            return Ok("dddd");
        }
    }
}
