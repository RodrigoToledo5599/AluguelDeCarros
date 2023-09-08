using AluguelDeCarros.Data.Context;
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

        [HttpGet("gg")]
        public IActionResult Autenticar()
        {
            return Ok("Identity é uma merda, VTNC");
        }
    }
}
