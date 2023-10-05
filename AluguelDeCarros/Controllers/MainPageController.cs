using AluguelDeCarros.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainPageController : ControllerBase
    {
        private readonly AppDbContext _db;
        
        public MainPageController(AppDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult ListCars()
        {
            var listaDeCarros = _db.Carros.ToList();
            return Ok(listaDeCarros);
        }

    }
}
