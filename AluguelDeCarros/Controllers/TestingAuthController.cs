using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestingAuthController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return Ok("nice mano, vc conseguiu se autenticar");
        }
    }
}
